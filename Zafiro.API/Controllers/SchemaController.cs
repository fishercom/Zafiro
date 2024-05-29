using Microsoft.AspNetCore.Mvc;

using Zafiro.Domain.Entities;
using Zafiro.Application.Services;
using Zafiro.Infrastructure.Context;
using Zafiro.Infrastructure.Context.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Zafiro.WebAPI.Controllers;

[Route("api/[controller]")]
public class SchemaController : Controller
{
    SchemaService CreateService()
    {
        CmsContext db = new CmsContext();
        SchemaRepository repSchema = new SchemaRepository(db);
        FieldRepository repField = new FieldRepository(db);
        SchemaService service = new SchemaService(repSchema, repField);
        return service;
    }


    // GET: api/values
    [HttpGet]
    public ActionResult<List<Schema>> Get()
    {
        var service = CreateService();
        return Ok(service.List());
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<Schema> Get(Guid id)
    {
        var service = CreateService();
        return Ok(service.Find(id));
    }

    // POST api/values
    [HttpPost]
    public ActionResult Post([FromBody] Schema schema)
    {
        var service = CreateService();
        service.Add(schema);
        return Ok("Added Successfully!");
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public ActionResult Put(Guid id, [FromBody] Schema schema)
    {
        var service = CreateService();
        schema.Id = id;
        service.Edit(schema);
        return Ok("Updated Successfully!");
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public ActionResult Delete(Guid id)
    {
        var service = CreateService();
        service.Delete(id);
        return Ok("Deleted Successfully!");
    }
}

