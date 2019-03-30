using System.Collections.Generic;
using Catharsium.GitTools.Core.Entities.Interfaces;

namespace Catharsium.GitTools.Core.Entities.Commands
{
    public class AddCommandOptions : IGitCommandOptions
    {
        public List<string> Files;
    }
}