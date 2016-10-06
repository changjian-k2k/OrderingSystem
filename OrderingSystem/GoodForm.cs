using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    public class GoodForm : INotifyPropertyChanged
    {
        int _id;
        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                if (this._id != value)
                {
                    _id = value;
                    OnPropertyChanged(nameof(Id));
                }
            }
        }

        string _name;
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (this._name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        string _color;
        public string Color
        {
            get
            {
                return this._color;
            }
            set
            {
                if (this._color != value)
                {
                    _color = value;
                    OnPropertyChanged(nameof(Color));
                }
            }
        }

        string _size;
        public string Size
        {
            get
            {
                return this._size;
            }
            set
            {
                if (this._size != value)
                {
                    _size = value;
                    OnPropertyChanged(nameof(Size));
                }
            }
        }

        decimal? _price;
        public decimal? Price
        {
            get
            {
                return this._price;
            }
            set
            {
                if (this._price != value)
                {
                    _price = value;
                    OnPropertyChanged(nameof(Price));
                }
            }
        }

        string _photo;
        public string Photo
        {
            get
            {
                return this._photo;
            }
            set
            {
                if (this._photo != value)
                {
                    _photo = value;
                    OnPropertyChanged(nameof(Photo));
                }

            }
        }


        string _comment;
        public string Comment
        {
            get
            {
                return this._comment;
            }
            set
            {
                if (this._comment != value)
                {
                    _comment = value;
                    OnPropertyChanged(nameof(Comment));
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string strName)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(strName));
            }
        }
    }
}
