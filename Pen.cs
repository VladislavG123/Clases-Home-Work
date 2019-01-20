using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClases
{
   public class Pen
    {
        private string _manufacturer;
        private bool _isBallPen;
        private string _colorBody;
        private string _colorInk;
        private bool _isAutomatic;

        public Pen()
        {
            _manufacturer = "China";
            _isAutomatic = false;
            _isBallPen = true;
            _colorInk = "Blue";
            _colorBody = "White";
        }
        public Pen(string manufacturer, string colorBody, string colorInk, bool isBallPen, bool isAutomatic)
        {
            _manufacturer = manufacturer;
            _colorBody = colorBody;
            _colorInk = colorInk;
            _isBallPen = isBallPen;
            _isAutomatic = isAutomatic;
        }
        

        #region Getters and Setters
        public string GetManufacturer()
        {
            return _manufacturer;
        }
        public bool IsBallPen()
        {
            return _isBallPen;
        }
        public string GetColorBody()
        {
            return _colorBody;
        }
        public string GetColorInk()
        {
            return _colorInk;
        }
        public bool IsAutomatic()
        {
            return _isAutomatic;
        }
        public void SetManufacturer(string manufacturer)
        {
            _manufacturer = manufacturer;
        }
        public void SetIsAutomatic(bool isAutomatic)
        {
            _isAutomatic = isAutomatic;
        }
        public void SetIsBallPen(bool isBallPen)
        {
            _isBallPen = isBallPen;
        }
        public void SetColorBody(string colorBody)
        {
            _colorBody = colorBody;
        }
        public void SetColorInk(string colorInk)
        {
            _colorInk = colorInk;
        }
        #endregion

       void CopyPen(ref Pen pen)
       {
            _manufacturer = pen.GetManufacturer();
            _isAutomatic = pen.IsAutomatic();
            _isBallPen = pen.IsBallPen();
            _colorInk = pen.GetColorInk();
            _colorBody = pen.GetColorBody();
       }


    }
}
