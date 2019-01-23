﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entities;

namespace Entities
{
    public class AlternativeOrderDetails : UniversalEntity
    {
        #region Attributes

        int _ID;
        int _SOrderID;
        int _VodomerID;
        string _StartValue;
        string _EndValue;
        double _SpecialPrice;
        double _ReplacementPrice;
        double _DismantlingPrice;
        double _InstallPrice;
        double _PhysicalPrice;

        #endregion

        #region Properties

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public int SOrderID
        {
            get { return _SOrderID; }
            set { _SOrderID = value; }
        }

        public int VodomerID
        {
            get { return _VodomerID; }
            set { _VodomerID = value; }
        }

        public string StartValue
        {
            get { return _StartValue; }
            set { _StartValue = value; }
        }

        public string EndValue
        {
            get { return _EndValue; }
            set { _EndValue = value; }
        }

        public double SpecialPrice
        {
            get { return _SpecialPrice; }
            set { _SpecialPrice = value; }
        }

        public double ReplacementPrice
        {
            get { return _ReplacementPrice; }
            set { _ReplacementPrice = value; }
        }

        public double DismantlingPrice
        {
            get { return _DismantlingPrice; }
            set { _DismantlingPrice = value; }
        }

        public double InstallPrice
        {
            get { return _InstallPrice; }
            set { _InstallPrice = value; }
        }

        public double PhysicalPrice
        {
            get { return _PhysicalPrice; }
            set { _PhysicalPrice = value; }
        }

        #endregion

        #region Methods

        public AlternativeOrderDetails()
        {
            _ID = 0;
            _SOrderID = 0;
            _VodomerID = 0;
            _StartValue = "";
            _EndValue = "";
            _SpecialPrice = 0;
            _ReplacementPrice = 0;
            _DismantlingPrice = 0;
            _InstallPrice = 0;
            _PhysicalPrice = 0;
        }

        #endregion
    }
}