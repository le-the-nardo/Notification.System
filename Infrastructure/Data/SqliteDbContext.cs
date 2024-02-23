/*using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class SqliteDbContext(DbContextOptions<SqliteDbContext> options, DbSet<LogMessage> logMessages)
    : DbContext(options)
{
    public DbSet<LogMessage> LogMessages { get; set; } = logMessages;
}*/