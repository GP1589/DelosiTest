using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Delosi.Models;
using Delosi.Services;
using Delosi.Validators;

namespace Delosi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatrixController : ControllerBase
    {
        private readonly IMatrixService _matrixService;

        public MatrixController(IMatrixService matrixService)
        {
            _matrixService = matrixService;
        }

        [HttpPost("rotate")]
        public IActionResult RotateMatrix([FromBody] MatrixModel matrixModel)
        {
            if (!MatrixValidator.IsValidMatrix(matrixModel.Matrix))
            {
                return BadRequest("Invalid NxN matrix.");
            }

            var rotatedMatrix = _matrixService.RotateMatrix(matrixModel.Matrix);
            return Ok(rotatedMatrix);
        }
    }
}
