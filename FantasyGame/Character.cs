using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyGame
{
    public class Character
    {
        #region Fields
        protected string strName;
        protected byte byteLevel;


        #endregion

        #region Constructor
        public Character(string name, byte level)
        {
            strName = name;
            ByteLevel = level;
        }
        #endregion


        #region Properties


        public string StrName
        {
            get { return strName; }

            set
            {
                if(value != strName)
                {
                    strName = value;
                }
            }
        }

        public byte ByteLevel
        {
            get { return byteLevel; }

            set
            {
                if(value != byteLevel)
                {
                    byteLevel = value;
                }
            }
        }

        #endregion

        #region Methods
        public virtual string ToString()
        {
            string placeHolder = "";



            return placeHolder;
        }

        #endregion
    }
}
