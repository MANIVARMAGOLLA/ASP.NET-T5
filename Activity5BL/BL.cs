using Activity5DAL;
using Activity5DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity5BL
{
    public class BL
    {
        public int InsertIntoProduct(DTO newProObj)
        {
            try
            {
                DAL dalObj = new DAL();
                int result = dalObj.InsertIntoPro(newProObj);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
