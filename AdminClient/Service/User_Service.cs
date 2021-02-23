using AdminClientVO;
using AdminClientDAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient
{
    class User_Service
    {
        public bool RegisterUser(UserInfoVO vo)
        {
            User_DAC dac = new User_DAC();
            return dac.RegisterUser(vo);
        }

        public UserInfoVO Login(UserInfoVO vo)
        {
            User_DAC dac = new User_DAC();
            return dac.Login(vo);
        }

        public int IDSearch(UserInfoVO vo)
        {
            User_DAC dac = new User_DAC();
            return dac.IDSearch(vo);
        }

        public bool IDSearch(string user_ID)
        {
            User_DAC dac = new User_DAC();
            bool result = dac.IDSearch(user_ID);
            dac.Dispose();
            return result;
        }

        public string GetID(UserInfoVO vo)
        {
            User_DAC dac = new User_DAC();
            string result = dac.GetID(vo);
            dac.Dispose();
            return result;
        }

        public int PwdSearch(UserInfoVO vo)
        {
            User_DAC dac = new User_DAC();
            return dac.PwdSearch(vo);
        }

        public bool UpdatePwd(string UserID, string Pwd)
        {
            User_DAC dac = new User_DAC();
            bool result = dac.UpdatePwd(UserID, Pwd);
            dac.Dispose();
            return result;
        }

        public bool UpdatePwd(string UserID, string UserEmail, string Pwd,string UserName)
        {
            User_DAC dac = new User_DAC();
            bool result = dac.UpdatePwd(UserID, UserEmail, Pwd, UserName);
            dac.Dispose();
            return result;
        }

        public bool AddWishList(WishListVO vo)
        {
            User_DAC dac = new User_DAC();
            return dac.AddWishList(vo);
        }

        public List<MyWishInfoVO> GetAllMyWishList(string id)
        {
            User_DAC dac = new User_DAC();
            return dac.GetAllMyWishList(id);
        }

        public List<MyCartListVO> GetAllMyCartList(string id)
        {
            User_DAC dac = new User_DAC();
            return dac.GetAllMyCartList(id);
        }

        internal bool SendCartList(List<MyWishInfoVO> checkList, string uid)
        {
            User_DAC dac = new User_DAC();
            return dac.SendCartList(checkList, uid);
        }

        public List<MyPurchaseInfoVO> GetMyPurchaseList(string id)
        {
            User_DAC dac = new User_DAC();
            return dac.GetMyPurchaseList(id);
        }
        internal bool DelCartList(int cartNum)
        {
            User_DAC dac = new User_DAC();
            return dac.DelCartList(cartNum);
        }

        internal bool DelWishList(List<int> delWishList)
        {
            User_DAC dac = new User_DAC();
            bool result = dac.DelWishList(delWishList);
            dac.Dispose();
            return result;
        }
    }
}
