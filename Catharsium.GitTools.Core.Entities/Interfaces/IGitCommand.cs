using System.Collections.Generic;

namespace Catharsium.GitTools.Core.Entities.Interfaces
{
    public interface IGitCommand<T> where T : IGitCommandOptions
    {
        List<string> GetCommands();
    }
}