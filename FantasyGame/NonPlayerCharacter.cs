using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyGame
{
    class NonPlayerCharacter : Character
    {
        #region Fields
        protected bool isActive;
        #endregion

        #region Constructor
        public NonPlayerCharacter(string name, byte level, bool isActive) : base(name, level)
        {
            IsActive = isActive;
        }

        #endregion

        #region Properties
        public bool IsActive
        {
            get { return isActive; }
            set
            {
                if(value != isActive)
                {
                    isActive = value;
                }
            }
        }
        #endregion


        #region methods
        public override string ToString()
        {
            return base.ToString();
        }

        #endregion

    }
}
