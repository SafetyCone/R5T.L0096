using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;

using R5T.L0091.T000;
using R5T.L0092.T001;
using R5T.T0241;

using R5T.L0096.T000;


namespace R5T.L0096.O003
{
    [ContextOperationsMarker]
    public partial interface IProjectContextOperations : IContextOperationsMarker
    {
        public Func<TContext, Task> In_CreateProjectFileContext<TContext>(
            out IChecked<IFileExists> projectFileChecked,
            IEnumerable<Action<XElement>> projectXElementOperations)
            where TContext : IHasProjectFilePath
        {
            projectFileChecked = Checked.Check<IFileExists>();

            return context =>
            {
                var projectXElement = Instances.ProjectXElementOperator.New_ProjectXElement();

                Instances.ContextOperator.In_Context(
                    projectXElement,
                    projectXElementOperations);

                return Instances.ProjectXElementOperator.To_File_Separated(
                        context.ProjectFilePath,
                        projectXElement);
            };
        }

        public Func<TContext, Task> In_CreateProjectFileContext<TContext>(
            out IChecked<IFileExists> projectFileChecked,
            Func<TContext, IEnumerable<Action<XElement>>> projectXElementOperationsGenerator)
            where TContext : IHasProjectFilePath
        {
            projectFileChecked = Checked.Check<IFileExists>();

            return context =>
            {
                var projectXElementOperations = projectXElementOperationsGenerator(context);

                var projectXElement = Instances.ProjectXElementOperator.New_ProjectXElement();

                Instances.ContextOperator.In_Context(
                    projectXElement,
                    projectXElementOperations);

                return Instances.ProjectXElementOperator.To_File_Separated(
                        context.ProjectFilePath,
                        projectXElement);
            };
        }
    }
}
