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

namespace MongoDB.EntityFrameworkCore.Metadata;

/// <summary>
/// Names for well-known Mongo model annotations. Applications should not use these names
/// directly, but should instead use the extension methods on metadata objects.
/// </summary>
public static class MongoAnnotationNames
{
    /// <summary>
    /// The prefix used for all MongoDB annotations.
    /// </summary>
    public const string Prefix = "Mongo:";

    /// <summary>
    /// The key for collection name annotations.
    /// </summary>
    public const string CollectionName = Prefix + "CollectionName";

    /// <summary>
    /// The key for document element name annotations.
    /// </summary>
    public const string ElementName = Prefix + "ElementName";

    /// <summary>
    /// The key for DateTimeKind name annotations.
    /// </summary>
    public const string DateTimeKind = Prefix + "DateTimeKind";
}
