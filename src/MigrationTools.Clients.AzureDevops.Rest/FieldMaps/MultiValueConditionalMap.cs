﻿using System;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using MigrationTools._EngineV1.Configuration;
using MigrationTools._EngineV1.Configuration.FieldMap;

namespace MigrationTools.Clients.AzureDevops.Rest.FieldMaps
{
    public class MultiValueConditionalMap : FieldMapBase
    {
        private MultiValueConditionalMapConfig Config { get { return (MultiValueConditionalMapConfig)_Config; } }

        public override void Configure(IFieldMapConfig config)
        {
            base.Configure(config);
        }

        public override string MappingDisplayName => string.Empty;

        internal override void InternalExecute(WorkItem source, WorkItem target)
        {
            throw new NotImplementedException();
        }
    }
}