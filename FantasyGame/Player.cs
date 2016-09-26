using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyGame
{
    class Player : Character
    {
        #region Fields
        protected TimeSpan timeSpanGameTime;
        #endregion

        #region Constructor
        public Player(string name, byte level, TimeSpan timeSpanGameTime) : base(name, level)
        {
            TimeSpanGameTime = timeSpanGameTime;
        }

        #endregion

        #region Properties
        public TimeSpan TimeSpanGameTime
        {
            get { return timeSpanGameTime; }
            set
            {
                if (value != timeSpanGameTime)
                {
                    timeSpanGameTime = value;
                }
            }
        }
        #endregion


        #region method
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}
