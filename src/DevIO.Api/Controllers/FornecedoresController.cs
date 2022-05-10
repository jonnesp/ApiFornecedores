﻿using AutoMapper;
using DevIO.Api.ViewModels;
using DevIO.Business.Intefaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevIO.Api.Controllers
{
    [Route("api/[controller]")]
    public class FornecedoresController : MainController
    {
        private readonly IFornecedorRepository _repository;
        private readonly IMapper _mapper;

        public FornecedoresController(IFornecedorRepository repository,
                                      IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ActionResult<IEnumerable<FornecedorViewModel>>> ObterTodos()
        {
            var fornecedor = _mapper.Map<IEnumerable<FornecedorViewModel>>(await _repository.ObterTodos());

            return Ok(fornecedor);
        }





    }
}