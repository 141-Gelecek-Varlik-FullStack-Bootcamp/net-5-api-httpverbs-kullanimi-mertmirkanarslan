using Datas;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GelecekVarlikWeek1Homework.Controllers
{
    //route üzerinde template'e s ekliyoruz, bunun sebebi domain.com/api/user gibi bir kullanım yerine domain.com/api/users şeklinde oluşturmasını istememiz.
    [Route("api/[controller]s")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //statik user listesi oluşturuyorum:
        private static List<User> users = new List<User>()
        {
            new User
            {
                Id=1,
                Name="Mert Mirkan",
                Surname="Arslan",
                Age=27,
                Email="mertmirkanarslan@gmail.com",
                Password="1234567"
            },
            new User
            {
                Id=2,
                Name="Vítor Manuel de Oliveira Lopes",
                Surname="Pereira",
                Age=53,
                Email="elitecoach@gmail.com",
                Password="fenerbahce"
            },
            new User
            {
                Id=3,
                Name="Marcelo Alberto",
                Surname="Bielsa",
                Age=66,
                Email="el-loco@gmail.com",
                Password="sahayimilyonaboldum"
            },
            new User
            {
                Id=4,
                Name="Josep 'Pep'",
                Surname="Guardiola",
                Age=50,
                Email="isimgucum@futbol.com",
                Password="beylerpaslibeyler"
            },
            new User
            {
                Id=5,
                Name="Christoph Paul",
                Surname="Daum",
                Age=66,
                Email="gorevehazirim@gazi.com",
                Password="fenerbahce1907"
            },
        };

        //get, post, put, delete işlemleri yapılacak. 
        // User Login, New User, User Detail


        // Users List


    }
}
