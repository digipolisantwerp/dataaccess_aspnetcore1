﻿using System;
using Toolbox.DataAccess.Options;
using Xunit;

namespace Toolbox.DataAccess.UnitTests.ConnectionStringTests
{
    public class InstantiationTests
    {
        [Fact]
        private void HostNullRaisesArgumentNullException()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => new TestConnectionString(null, 1234, "db", "user", "pwd"));
            Assert.Equal("host", ex.ParamName);
        }

        [Fact]
        private void HostEmptyRaisesArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => new TestConnectionString("", 1234, "db", "user", "pwd"));
            Assert.Equal("host", ex.ParamName);
        }

        [Fact]
        private void HostWhiteSpaceRaisesArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => new TestConnectionString("  ", 1234, "db", "user", "pwd"));
            Assert.Equal("host", ex.ParamName);
        }

        [Fact]
        private void DbNameNullRaisesArgumentNullException()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => new TestConnectionString("host", 1234, null, "user", "pwd"));
            Assert.Equal("dbname", ex.ParamName);
        }

        [Fact]
        private void DbNameEmptyRaisesArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => new TestConnectionString("host", 1234, "", "user", "pwd"));
            Assert.Equal("dbname", ex.ParamName);
        }

        [Fact]
        private void DbNameWhiteSpaceRaisesArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => new TestConnectionString("host", 1234, "   ", "user", "pwd"));
            Assert.Equal("dbname", ex.ParamName);
        }

        [Fact]
        private void UserNullRaisesArgumentNullException()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => new TestConnectionString("host", 1234, "db", null, "pwd"));
            Assert.Equal("user", ex.ParamName);
        }

        [Fact]
        private void UserEmptyRaisesArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => new TestConnectionString("host", 1234, "db", "", "pwd"));
            Assert.Equal("user", ex.ParamName);
        }

        [Fact]
        private void UserWhiteSpaceRaisesArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => new TestConnectionString("host", 1234, "db", "  ", "pwd"));
            Assert.Equal("user", ex.ParamName);
        }

        [Fact]
        private void PasswordNullRaisesArgumentNullException()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => new TestConnectionString("host", 1234, "db", "user", null));
            Assert.Equal("password", ex.ParamName);
        }

        [Fact]
        private void PasswordEmptyRaisesArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => new TestConnectionString("host", 1234, "db", "user", ""));
            Assert.Equal("password", ex.ParamName);
        }

        [Fact]
        private void PasswordWhiteSpaceRaisesArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => new TestConnectionString("host", 1234, "db", "user", "  "));
            Assert.Equal("password", ex.ParamName);
        }

        [Fact]
        private void HostIsSet()
        {
            var conn =  new TestConnectionString("host", 1234, "db", "user", "pwd");
            Assert.Equal("host", conn.Host);
        }

        [Fact]
        private void PortIsSet()
        {
            var conn = new TestConnectionString("host", 1234, "db", "user", "pwd");
            Assert.Equal(1234, conn.Port);
        }

        [Fact]
        private void DbNameIsSet()
        {
            var conn = new TestConnectionString("host", 1234, "db", "user", "pwd");
            Assert.Equal("db", conn.DbName);
        }

        [Fact]
        private void UserIsSet()
        {
            var conn = new TestConnectionString("host", 1234, "db", "user", "pwd");
            Assert.Equal("user", conn.User);
        }

        [Fact]
        private void PasswordIsSet()
        {
            var conn = new TestConnectionString("host", 1234, "db", "user", "pwd");
            Assert.Equal("pwd", conn.Password);
        }

        [Fact]
        private void PortZeroIsAllowed()
        {
            var conn = new TestConnectionString("host", 0, "db", "user", "pwd");
            Assert.Equal(0, conn.Port);
        }
    }
}
