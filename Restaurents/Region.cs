using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Restaurents
{
   public class Region
    {
        private Database _database;
        public Region()
        {
            _database = new Database();
        }
        public List<RegionObj> DisplayRegions()
        
        {
            List<RegionObj> regionObjList = new List<RegionObj>();
            DataTable dt = _database.GetTable("GetAllRegions");

            foreach (DataRow row in dt.Rows)
            {
                RegionObj region = new RegionObj();
                region.Id = int.Parse(row[0].ToString());
                region.Name = row[1].ToString();
                regionObjList.Add(region);
            }
           
            return regionObjList;
        }
    }
}
