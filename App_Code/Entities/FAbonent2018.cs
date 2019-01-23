using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Windows.Forms;

namespace Entities
{
    public class FAbonent2018:UniversalEntity
    {
        #region Attributes

        int _ID;
        string _FirstName;
        string _Surname;
        string _LastName;
        int _DistrictID;
        string _Phone;
        string _Address;
        bool _NotPay;
        bool _IsDeleted;
        string _NumberJournal;

        #endregion

        #region Properties

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string Surname
        {
            get { return _Surname; }
            set { _Surname = value; }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public int DistrictID
        {
            get { return _DistrictID; }
            set { _DistrictID = value; }
        }

        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public bool NotPay
        {
            get { return _NotPay; }
            set { _NotPay = value; }
        }

        public bool IsDeleted
        {
            get { return _IsDeleted; }
            set { _IsDeleted = value; }
        }

        public string NumberJournal
        {
            get { return _NumberJournal; }
            set { _NumberJournal = value; }
        }

        #endregion

        #region Methods

        public FAbonent2018()
        {
            _ID = 0;
            _FirstName = "";
            _Surname = "";
            _LastName = "";
            _DistrictID = 0;
            _Phone = "";
            _Address = "";
            _NotPay = false;
            _IsDeleted = false;
            _NumberJournal = "";
        }

        #endregion
    }
}