﻿using System;
using Microsoft.Extensions.DependencyInjection;
using Toolbox.DataAccess.Entiteiten;
using Toolbox.DataAccess.Options;
using Toolbox.DataAccess.StartupExtensions;
using Xunit;

namespace Toolbox.DataAccess.UnitTests.DataAccessServiceCollectionExtensionsTests
{
    public class AddDataAccessTests
    {
        //[Fact]
        //private void JsonFilenameNullRaisesArgumentNullException()
        //{
        //    string nullString = null;
        //    var serviceCollection = new ServiceCollection();
        //    var ex = Assert.Throws<ArgumentNullException>(() => serviceCollection.AddDataAccess<EntityContextBase>(nullString));
        //    Assert.Equal("optionsFilePath", ex.ParamName);
        //}

        //[Fact]
        //private void JsonFilenameEmptyRaisesArgumentException()
        //{
        //    var emptyString = "";
        //    var serviceCollection = new ServiceCollection();
        //    var ex = Assert.Throws<ArgumentException>(() => serviceCollection.AddDataAccess<EntityContextBase>(emptyString));
        //    Assert.Equal("optionsFilePath", ex.ParamName);
        //}

        //[Fact]
        //private void JsonFilenameWhiteSpaceRaisesArgumentException()
        //{
        //    var spaces = "  ";

        //    var serviceCollection = new ServiceCollection();
        //    var ex = Assert.Throws<ArgumentException>(() => serviceCollection.AddDataAccess<EntityContextBase>(spaces));
        //    Assert.Equal("optionsFilePath", ex.ParamName);
        //}

        //[Fact]
        //private void JsonFileInstantiatesConnectionString()
        //{
        //    var jsonFilename = "_TestData/dbconfig.json";

        //    var serviceCollection = new ServiceCollection();
        //    IServiceCollection collection = serviceCollection.AddDataAccess<EntityContextBase>(jsonFilename);

        //    var options = collection.BuildServiceProvider().GetService<DataAccessOptions>();

        //    Assert.NotNull(options.ConnectionString);
        //    Assert.Equal("host", options.ConnectionString.Host);
        //    Assert.Equal(1234, options.ConnectionString.Port);
        //    Assert.Equal("db", options.ConnectionString.DbName);
        //    Assert.Equal("user", options.ConnectionString.User);
        //    Assert.Equal("pwd", options.ConnectionString.Password);
        //}
    }
}
