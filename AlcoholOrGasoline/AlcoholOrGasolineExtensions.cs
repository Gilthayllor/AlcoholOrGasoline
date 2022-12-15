using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholOrGasoline
{
    public static class AlcoholOrGasolineExtensions
    {
        public enum AlcoholOrGasolineEnum
        {
            Alcohol,
            Gasoline
        }

        /// <summary>
        /// This method calculates wether it is cheaper fill up with alcohol or gasoline.
        /// </summary>
        /// <param name="alcoholPrice">Alcohol price</param>
        /// <param name="gasolinePrice">Gasoline Price</param>
        /// <returns><see cref="AlcoholOrGasolineEnum"/></returns>
        public static AlcoholOrGasolineEnum Calculate(decimal alcoholPrice, decimal gasolinePrice)
        {
            if(alcoholPrice < gasolinePrice * 0.7M)
                return AlcoholOrGasolineEnum.Alcohol;

            return AlcoholOrGasolineEnum.Gasoline;
        }
    }
}
