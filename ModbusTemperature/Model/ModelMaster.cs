using Dapper;


namespace ModbusTemperature.Model
{
    public class ModelMaster

    {
        // Assuming badgeId and SerialNumber are strings, but change this as needed
        public string badgeId { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        public DateTime RecordedAt { get; set; } = DateTime.Now;
        public int Interval { get; set; } = 1000;

        // Metode untuk menyimpan data suhu ke database
        public static void SaveDataMaster(string badgeId, List<string> SerialNumber,int interval)
        {
            using (var connection = ConfigDB.GetConnection())
            {
                var query = "INSERT INTO TemperatureDataMaster (badgeId, SerialNumber,Interval, RecordedAt) " +
                            "VALUES (@badgeId, @SerialNumber,@Interval, @recordedAt)";
                // Assuming you want to record the time in RecordedAt field
                var parameters = SerialNumber.Select(sn => new { badgeId, SerialNumber = sn,Interval=interval, recordedAt = DateTime.Now }).ToList();

                // Menyimpan banyak data dalam satu batch
                connection.Execute(query, parameters);
            }
        }

        public static ModelMaster? GetLastMasterDataByScanCodeTime()
        {
            using (var connection = ConfigDB.GetConnection())
            {
                string query = @"SELECT badgeId,SerialNumber,RecordedAt,Interval
                                    FROM [TemperatureDataMaster]  order by recordedAt Desc";
                // Assuming you want to record the time in RecordedAt field
                var dataMaster = connection.Query<ModelMaster>(query).FirstOrDefault();
                return dataMaster;
            }
        }
        public static List<ModelMaster>? GetLastListMasterDataByScanCodeTime()
        {
            using (var connection = ConfigDB.GetConnection())
            {
                string query = @"SELECT badgeId,SerialNumber,RecordedAt,Interval
                                    FROM [TemperatureDataMaster] where RecordedAt=(Select top 1 RecordedAt from TemperatureDataMaster group by RecordedAt order by RecordedAt desc) order by recordedAt Desc";
                // Assuming you want to record the time in RecordedAt field
                var dataMaster = connection.Query<ModelMaster>(query).ToList();
                return dataMaster;
            }
        }
        public static List<ModelMaster>? GetMasterModelBySerial(params string[] serials)
        {
            using (var connection = ConfigDB.GetConnection())
            {
;                string query = $@"SELECT badgeId,SerialNumber,RecordedAt,Interval
                                    FROM [TemperatureDataMaster] where SerialNumberIn (@sn) order by recordedAt Desc";
                // Assuming you want to record the time in RecordedAt field
                var dataMaster = connection.Query<ModelMaster>(query,new {sn=serials}).ToList();
                return dataMaster;
            }
        }
        public static List<ModelDetail> GetLastTemperatureDataByScanCodeTime()
        {
            using (var connection = ConfigDB.GetConnection())
            {
                string query = @"SELECT badgeId,SerialNumber,RecordedAt,Interval
                                    FROM [TemperatureDataMaster] order by recordedAt Desc";
                // Assuming you want to record the time in RecordedAt field
                var dataMaster = connection.Query<ModelMaster>(query).FirstOrDefault();
                if (dataMaster is null)
                    return new List<ModelDetail>();
                query = @"SELECT SerialNumber,TemperatureData,RecordedAt,Interval FROM TemperatureDataDetail where SerialNumber=@SerialNumber";
                return connection.Query<ModelDetail>(query,new { SerialNumber=dataMaster.SerialNumber}).ToList();
            }
        }
        public void SaveMaster()
        {
            using (var connection = ConfigDB.GetConnection())
            {
                string query = "INSERT INTO TemperatureDataMaster (badgeId, SerialNumber, RecordedAt,Interval) " +
                               "VALUES (@badgeId, @SerialNumber, @recordedAt,@Interval)";
                connection.Execute(query, this);
            }
        }

        // Metode untuk mengecek keberadaan badgeId di database
        public static bool IsBadgeIdExists(string badgeId)
        {
            using (var connection = ConfigDB.GetConnection())
            {
                string query = "SELECT COUNT(1) FROM Employee WHERE badgeId = @badgeId";
                int count = connection.ExecuteScalar<int>(query, new { badgeId });
                return count > 0;
            }
        }
    }
}
