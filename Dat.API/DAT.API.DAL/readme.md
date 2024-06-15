### Scaffold-DbContext

navigate to project folder:

```
cd .\DAT.DAL\
```

run scaffolding:
_replace conneciton string with yours if needed_

```
dotnet ef dbcontext scaffold `
"Server=DESKTOP-HPNA4RC;Database=Dat;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;" `
Microsoft.EntityFrameworkCore.SqlServer `
`
--table Products `
--table Sellers `
`
--data-annotations `
--context AppDbContext `
--context-dir Context `
--output-dir Models `
--no-onconfiguring `
--force `
--verbose
```
	