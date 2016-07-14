﻿using System.Collections.Generic;
using Foundatio.Repositories.Elasticsearch.Queries.Builders;
using Foundatio.Repositories.Queries;

namespace Foundatio.Repositories.Elasticsearch.Queries {
    public class ParentQuery : ISystemFilterQuery, IIdentityQuery, IDateRangeQuery, IFieldConditionsQuery, ISearchQuery, ITypeQuery {
        public ParentQuery() {
            DateRanges = new List<DateRange>();
            FieldConditions = new List<FieldCondition>();
            Ids = new List<string>();
        }

        public List<string> Ids { get; }
        public string Type { get; set; }
        public List<DateRange> DateRanges { get; }
        public List<FieldCondition> FieldConditions { get; }
        public object SystemFilter { get; set; }
        public string Filter { get; set; }
        public string SearchQuery { get; set; }
        public SearchOperator DefaultSearchQueryOperator { get; set; }
    }
}