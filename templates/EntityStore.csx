public string WriteCode()
{
    if (Entity.Models.Count == 0)
        return string.Empty;

    var modelNamespace = Entity.Models.Select(m => m.ModelNamespace).FirstOrDefault();
    var readModel = string.Empty;
    var createModel = string.Empty;
    var updateModel = string.Empty;

    foreach (var model in Entity.Models)
    {
        switch (model.ModelType)
        {
            case ModelType.Read:
                readModel = model.ModelClass.ToSafeName();
                break;
            case ModelType.Create:
                createModel = model.ModelClass.ToSafeName();
                break;
            case ModelType.Update:
                updateModel = model.ModelClass.ToSafeName();
                break;
        }
    }

    if (string.IsNullOrEmpty(updateModel))
        return string.Empty;

    CodeBuilder.Clear();

    CodeBuilder.AppendLine("using System;");
    CodeBuilder.AppendLine();
    CodeBuilder.AppendLine("using AutoMapper;");
    CodeBuilder.AppendLine();
    CodeBuilder.AppendLine("using AzureNamer.Client.Repositories;");

    if (!string.IsNullOrEmpty(modelNamespace))
        CodeBuilder.AppendLine($"using {modelNamespace};");

    CodeBuilder.AppendLine();

    CodeBuilder.AppendLine($"namespace {TemplateOptions.Namespace};");
    CodeBuilder.AppendLine();

    GenerateClass(readModel, createModel, updateModel);

    CodeBuilder.AppendLine();

    return CodeBuilder.ToString();
}

private void GenerateClass(string readModel, string createModel, string updateModel)
{
    var className = System.IO.Path.GetFileNameWithoutExtension(TemplateOptions.FileName);
    var keyType = TemplateOptions.Parameters["keyType"];

    CodeBuilder.AppendLine("[RegisterScoped]");

    CodeBuilder.AppendLine($"public class {className} : StoreEditBase<{Entity.EntityClass}Repository, {keyType}, {readModel}, {readModel}, {updateModel}>");

    CodeBuilder.AppendLine("{");

    using (CodeBuilder.Indent())
    {
        GenerateConstructor(className);
    }

    CodeBuilder.AppendLine("}");

}

private void GenerateConstructor(string className)
{
    CodeBuilder.AppendLine($"public {className}(ILoggerFactory loggerFactory, {Entity.EntityClass}Repository repository, IMapper mapper) : base(loggerFactory, repository, mapper)");
    CodeBuilder.AppendLine("{");
    CodeBuilder.AppendLine("}");
    CodeBuilder.AppendLine();
}

// run script
WriteCode()
