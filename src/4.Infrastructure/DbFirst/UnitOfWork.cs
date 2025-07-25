﻿using DbFirst.Entities;
using Domain.DbFirst.Entities.Repository;
using Domain.DbFirst.Entities.UnitOfWork;

namespace DbFirst.Infrastructure.DbFirst;

public class UnitOfWork : IUnitOfWork
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly CursoEFContext _dbFirstCursoEFContext;

    public UnitOfWork(IEmployeeRepository employeeRepository, CursoEFContext dbFirstCursoEFContext)
    {
        _employeeRepository = employeeRepository;
        _dbFirstCursoEFContext = dbFirstCursoEFContext;
    }

    public IEmployeeRepository EmployeeRepository { get => _employeeRepository; }

    public async Task<int> SaveAsync()
    {
       return await _dbFirstCursoEFContext.SaveChangesAsync();
    }
}
