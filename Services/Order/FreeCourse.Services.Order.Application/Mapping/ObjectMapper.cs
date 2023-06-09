using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCourse.Services.Order.Application.Mapping
{
    //Class librarylerde DI Container olmadığı için manuel olarak bir statik sınıf oluşturup mapleme işleminde yardımcı olacağız
    public static class ObjectMapper
    {
        private static readonly Lazy<IMapper> lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CustomMapping>();
            });
            return config.CreateMapper();
        });

        public static IMapper Mapper => lazy.Value;//Ne zaman mapleme işlemini çağırısam o zaman çalışacak.Lazy Loading muhabbeti.
    }
}
