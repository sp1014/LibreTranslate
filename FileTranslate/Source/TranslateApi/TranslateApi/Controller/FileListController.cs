using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TranslateApi.Services;
using TranslateApi.Data;
using TranslateApi.Model;
using System;
using TranslateApi.Controllers;
using Microsoft.EntityFrameworkCore;

namespace TranslateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileListController : ControllerBase
    {

        public UpdateFiles updateFiles;
        #region Property  
        private readonly IFileService _fileService;
        #endregion

        private readonly UsersContext _contextfile;

        #region Constructor  
        public FileListController(IFileService fileService, UsersContext context)
        {
           _fileService = fileService;
            _contextfile = context; 
        }
        #endregion


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var UpdateFiles = await _contextfile.UpdateFiles.ToListAsync();

            return Ok(UpdateFiles);
        }

        #region listTranslate 
        [HttpPost("listTranslate")]

        public async Task<IActionResult> Post(UpdateFiles updateFiles )
        {
           updateFiles.CreatedDate = DateTime.Now;
       
            //updateFiles.IdUser = 1;
       

            if (updateFiles.Link != null)
            {
                updateFiles.Status = "Translation completed";
                updateFiles.EndDate = DateTime.Now;

            }
            else
            {
                updateFiles.Status = "Failed translation";
            }



            try
            {
               _contextfile.Add(updateFiles);
                await _contextfile.SaveChangesAsync();
                
                return Ok("Datos Guardados ");
          
            }
            catch (System.Exception)
            {

                throw;
            }

        }
        #endregion

        
    }
}


