using FreeCourse.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreeCourse.Shared.ControllerBases
{
    /* Class library olduğu için controllerbase inherit alamaz. O yüzden edit project files diyip aşağıdaki kodları ekleyince kütüphaneyi burada da kullanmayı sağlıyoruz.
     <ItemGroup>
		<FrameworkReference Include="Microsoft.AspNetCore.App"/>
	</ItemGroup>
    */
    public class CustomBaseController : ControllerBase
    {
        //Sonuç ne dönüyorsa kodunu otomatik olarak algılayacak. Kontrol etmemize gerek kalmayacak controllerda.
        public IActionResult CreateActionResultInstance<T>(Response<T> response)
        {
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode,
            };
        }
    }
}
