﻿/* Copyright 2023-present MongoDB Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Metadata;
using MongoDB.EntityFrameworkCore.Extensions;

namespace MongoDB.EntityFrameworkCore.Query;

/// <summary>
/// Represents a top-level MongoDB-specific collection for querying server-side.
/// </summary>
public class MongoQueryExpression : Expression
{
    /// <summary>
    /// Create a <see cref="MongoQueryExpression"/> for the given entity type.
    /// </summary>
    /// <param name="entityType">The <see cref="IEntityType"/> this collection relates to.</param>
    public MongoQueryExpression(IEntityType entityType)
        : this(new MongoCollectionExpression(entityType), entityType.GetCollectionName()!)
    {
    }

    /// <summary>
    /// Creates a <see cref="MongoQueryExpression"/> for the given entity type.
    /// </summary>
    /// <param name="fromExpression">The expression this query selects against.</param>
    /// <param name="collection">The name of the collection on the MongoDB server.</param>
    public MongoQueryExpression(MongoCollectionExpression fromExpression, string collection)
    {
        FromExpression = fromExpression;
        Collection = collection;
    }

    public virtual MongoCollectionExpression FromExpression { get; private set; }

    public Expression? ShuntedExpression { get; set; }

    /// <summary>
    /// The underlying name of the collection for this query in MongoDB.
    /// </summary>
    public virtual string Collection { get; }

    /// <inheritdoc />
    public override Type Type => typeof(object);

    /// <inheritdoc />
    public sealed override ExpressionType NodeType => ExpressionType.Extension;
}
