using Data.Models;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfSliderBarsDal : GenericRepository<SliderBars>,ISliderBarsDal
    {
    }
}
