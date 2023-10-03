﻿using App.Domain.Core.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Products.Contract.Repositories
{
    public interface ICategoryRepository
    {
        Task<int> Add(CategoryInputDto categoryInputDto, CancellationToken cancellationToken);
        Task<int> Update(int id, CategoryInputDto categoryInputDto, CancellationToken cancellationToken);
        Task<bool> Delete(CategoryOutputDto category, CancellationToken cancellationToken);
        Task<CategoryOutputDto> GetById(int id, CancellationToken cancellationToken);
        Task<List<CategoryOutputDto>> GetAll(CancellationToken cancellationToken);
    }
}
