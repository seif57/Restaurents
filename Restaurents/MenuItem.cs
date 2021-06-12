using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Restaurents
{
    public class MenuItem
    {
        private Database _database;
        public MenuItem()
        {
            _database = new Database();

        }
        
        public List<ItemObj> GetMenuById(int restaurentId)
        {

            List<ItemObj> itemObjsList = new List<ItemObj>();
            using (var con = DataBaseConnection.SqlConnection)
            {


                List<ParamObj> paramObjs = new List<ParamObj>();
                ParamObj paramObj = new ParamObj() { Name = "RestaurentId", Value = restaurentId, Type = ParamType.Int };
                paramObjs.Add(paramObj);
                DataTable dt = _database.GetTable("GetMenuByRestaurentId", paramObjs);
                foreach (DataRow row in dt.Rows)
                {
                    ItemObj itemObj = new ItemObj();
                    itemObj.Id = int.Parse(row[0].ToString());
                    itemObj.Name = row[1].ToString();
                    itemObj.Price = int.Parse(row[2].ToString());
                    itemObj.Info = row[3].ToString();
                    itemObj.RestaurentID = int.Parse(row[4].ToString());

                    itemObjsList.Add(itemObj);

                };
                return itemObjsList;
            }
        }
    }
    
}
