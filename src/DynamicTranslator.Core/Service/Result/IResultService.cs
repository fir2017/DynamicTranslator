﻿using System.Threading.Tasks;

using DynamicTranslator.Core.Domain.Uow;
using DynamicTranslator.Core.Orchestrators.Model;

namespace DynamicTranslator.Core.Service.Result
{
    #region using

    

    #endregion

    public interface IResultService : IApplicationService
    {
        [UnitOfWork]
        CompositeTranslateResult Get(string key);

        [UnitOfWork]
        Task<CompositeTranslateResult> GetAsync(string key);

        [UnitOfWork]
        CompositeTranslateResult Save(string key, CompositeTranslateResult translateResult);

        [UnitOfWork]
        CompositeTranslateResult SaveAndUpdateFrequency(string key, CompositeTranslateResult translateResult);

        [UnitOfWork]
        Task<CompositeTranslateResult> SaveAndUpdateFrequencyAsync(string key, CompositeTranslateResult translateResult);

        [UnitOfWork]
        Task<CompositeTranslateResult> SaveAsync(string key, CompositeTranslateResult translateResult);
    }
}