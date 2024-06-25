using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VController : ControllerBase
    {
        [HttpGet]
        [Route("AllBible")]

        public async Task<string[]> AllBible()
        {
            return await BLL.TextFun.AllBibleAsync();
        }

        [HttpGet]
        [Route("findWord/{word}")]

        public async Task<List<string>> findWord(string word)
        {
            return await BLL.TextFun.findWordAsync(word);         
        }

        [HttpGet]
        [Route("countWord/{word}")]

        public async Task<int[]> countWord(string word)
        {
            return await BLL.TextFun.countWordAsync(word);
        }

        [HttpGet]
        [Route("name/{word}")]

        public async Task<List<string>> name(string word)
        {
            return await BLL.TextFun.nameAsync(word);
        }
    }
}

