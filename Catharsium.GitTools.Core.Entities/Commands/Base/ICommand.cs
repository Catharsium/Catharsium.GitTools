using System.Collections.Generic;

namespace Catharsium.GitTools.Core.Entities.Commands.Base
{
    public interface ICommand<T> where T : ICommandOptions
    {
        List<string> GetCommands();
    }
}