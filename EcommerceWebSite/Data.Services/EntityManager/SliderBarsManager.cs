using Data.Models;
using Data.Services.Abstract;
using Data.Services.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services.EntityManager
{
    public class SliderBarsManager : GenericManager<SliderBars>, ISliderBarsService
    {
        public static SliderBarsManager Instance => new SliderBarsManager(new EfSliderBarsDal());
        ISliderBarsDal sliderBarsDal;
        public SliderBarsManager(IGenericDal<SliderBars> genericDal) : base(genericDal)
        {
            sliderBarsDal = new EfSliderBarsDal();
        }
    }
}
