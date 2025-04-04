﻿namespace Judge.Model.Entities;

using System;
using System.Linq.Expressions;
using Judge.Model.SubmitSolution;

public sealed class ContestUserSubmitsSpecification : ISpecification<SubmitBase>
{
    public ContestUserSubmitsSpecification(long userId, long contestId)
    {
        this.IsSatisfiedBy = submit => submit.UserId == userId &&
                                       submit is ContestTaskSubmit &&
                                       ((ContestTaskSubmit)submit).ContestId == contestId;
    }

    public Expression<Func<SubmitBase, bool>> IsSatisfiedBy { get; }
}