using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dockerApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace dockerApi.Controllers {
    [ApiController]
    [Route ("[controller]")]

    public class InputController : ControllerBase {

        private readonly ILogger<InputController> _logger;

        private readonly dockerApiContext _context;

        public InputController (ILogger<InputController> logger, dockerApiContext context) {
            _logger = logger;
            _context = context;
        }

        [HttpPost]
        public async Task<int> PostInput (Input input) {
            _context.Inputs.Add (input);
            await _context.SaveChangesAsync ();

            return input.Id;
        }

        [HttpGet]
        public async Task<List<Input>> ListInput () {
            return await _context.Inputs.ToListAsync ();
        }

    }
}