using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialDal
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            this._testimonialDal = testimonialDal;
        }

        public void Delete(Testimonial t)
        {
            _testimonialDal.Delete(t);
        }

        public List<Testimonial> GetByFilter(Expression<Func<Testimonial, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Testimonial GetByID(int id)
        {
            return _testimonialDal.GetByID(id);
        }

        public List<Testimonial> GetList()
        {
            return _testimonialDal.GetList();
        }

        public void Insert(Testimonial t)
        {
            _testimonialDal.Insert(t);
        }

        public void Update(Testimonial t)
        {
            _testimonialDal.Update(t);
        }
    }
}
