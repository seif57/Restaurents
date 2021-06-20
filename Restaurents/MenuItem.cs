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
        private List<ParamObj> CastObjToParams(ItemObj itemObj)
        {
            List<ParamObj> paramsObjList = new List<ParamObj>()
                {
                    new ParamObj("Name", itemObj.Name),
                    new ParamObj("Price", itemObj.Price),
                    new ParamObj("Info", itemObj.Info),
                };

            return paramsObjList;
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

        public void Update(ItemObj item)
        {
            using (var con = DataBaseConnection.SqlConnection)
            {
                List<ParamObj> paramObjs = CastObjToParams(item);
                paramObjs.Add(new ParamObj("ID", item.RestaurentID, ParamType.Int));
                DataTable dt = _database.GetTable("ModifyMenu", paramObjs);
            };
        }
        public void Add(ItemObj item)
        {
            List<ItemObj> itemObjList = new List<ItemObj>();

            using (var con = DataBaseConnection.SqlConnection)
            {

                List<ParamObj> paramObjs = CastObjToParams(item);
                DataTable dt = _database.GetTable("AddMenuItemt", paramObjs);
            }
        }
        public void Delete(int id)
        {
            using (var con = DataBaseConnection.SqlConnection)
            {

                List<ParamObj> paramObjs = new List<ParamObj>();
                ParamObj paramObj = new ParamObj() { Name = "Id", Value = id, Type = ParamType.Int };
                paramObjs.Add(paramObj);
                DataTable dt = _database.GetTable("DeleteMenuItem", paramObjs);



            }


        }
       
        public ItemObj GetItemInfo(int id) 
        
        {
            ItemObj itemObj = new ItemObj();


            using (var con = DataBaseConnection.SqlConnection)
            {

                
                List<ParamObj> paramObjs = new List<ParamObj>();
                ParamObj paramObj = new ParamObj() { Name = "Id", Value = id, Type = ParamType.Int };
                paramObjs.Add(paramObj);
                DataTable dt = _database.GetTable("GetItemInfo", paramObjs);

                foreach (DataRow row in dt.Rows)
                {
                    itemObj.Id = int.Parse(row[0].ToString());
                    itemObj.Name = row[1].ToString();
                    itemObj.Price = int.Parse(row[2].ToString());
                    itemObj.Info = row[3].ToString();
                    itemObj.RestaurentID = int.Parse(row[4].ToString());
                   
                }

            }


            return itemObj;
        }
    }
    
}
