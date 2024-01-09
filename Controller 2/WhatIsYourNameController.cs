using Microsoft.AspNetCore.Mvc;

namespace WhatIsYourName.controller;

[ApiController]
[Route("[controller]")]
    public class Controller: ControllerBase
    {
        public List <string> greeting = new();
        [HttpGet]
        [Route("Hello/{WhatIsYourName}/{WhatTimeDidYouWakeUp}")]
        public List <string> Hello(string WhatIsYourName , string WhatTimeDidYouWakeUp)
        {
            greeting.Add($"Hello, {WhatIsYourName}. I woke up at {WhatTimeDidYouWakeUp} ");
            return greeting;
        }
    }