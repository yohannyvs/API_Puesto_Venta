--inserts
create procedure insert_catalogo
( @categoria varchar ) as
begin
	if exists(select * from categoria where nombre_cat = @categoria)
		begin
			return (1)
		end
	else
		begin
			insert into categoria (nombre_cat) values (@categoria)
			return (0)
		end
end

Go

create procedure insert_producto
( @producto varchar,  @cod_cat integer, @marca varchar, @precio integer, @cantidad integer) as
begin

	if exists(select * from producto where nombreprod = @producto)
		begin
			return (1)
		end
	else
		begin
			insert into producto (nombreprod,cod_cat,marca,precio,cantidad) values(@producto,  @cod_cat, @marca, @precio, @cantidad)
			return (0)
		end
end

go

create procedure insert_carrito
( @correo varchar, @id_producto integer, @cantidad integer ) as
begin
	declare
		@id_u integer,
		@cant integer

		set @id_u = (select cedula from usuarios where correo=@correo)
		set @cant = (select cantidad from producto where cod_prod = @id_producto)

		if (@cant < @cantidad)
			begin
				return (1)
			end
		else 
			if (@cant >= @cantidad)
			begin
				insert into deseos (cedula,cod_prod,cantidad) values (@id_u,@id_producto,@cantidad);
				return (0)
			end
end

--Update

create procedure update_catalogo
(@cod_cat int, @categoria varchar) as
begin
	if exists(select * from categoria where cod_cat = @cod_cat)
		begin
			return (1);
		end
	else
		begin
			update categoria set nombre_cat = @categoria where cod_cat = @cod_cat;
			return (0)
		end
end

create procedure update_producto
(@cod_prod int, @producto varchar, @cod_cat integer, @marca varchar, @precio integer, @cantidad integer) as
begin
	if exists(select * from producto where cod_prod = @cod_prod)
		begin
			return (1)
		end
	else
		begin
			update producto set nombreprod = @producto, cod_cat = @cod_cat, marca = @marca, precio = @precio, cantidad = @cantidad where cod_prod = @cod_prod;
			return (0)
		end
end

create procedure update_carrito
(@correo varchar, @id_producto integer, @cantidad integer) as
begin
	declare
		@id_u integer,
		@cant integer

	set @id_u = (select cedula from usuarios where correo=@correo)
	set @cant = (select cantidad from producto where cod_prod = @id_producto)

	if (@cant < @cantidad)
		begin
			return (1)
		end
	else
		if(@cant >= @cantidad)
		begin
			update deseos set cantidad = @cantidad where cedula = @id_u and cod_prod = @id_producto
			return(0)
		end
end

--delete

create procedure delete_catalogo
(@cod_cat int) as
begin
	if exists(select * from categoria where cod_cat = @cod_cat)
		begin
			return (1)
		end
	else
		begin
			delete from categoria where cod_cat = @cod_cat
			return (0)
		end
end

create procedure delete_producto
(@cod_prod int) as
begin
	if exists(select * from producto where cod_prod = @cod_prod)
		begin
			return (1)
		end
	else
		begin
			delete from producto where cod_prod = @cod_prod
			return (0)
		end
end

create procedure delete_carrito
(@cod_des int) as
begin
	if exists(select * from deseos where cod_des = @cod_des)
		begin
			return (1)
		end
	else
		begin
			delete from deseos where cod_des = @cod_des
			return (0)
		end
end

--select

create procedure select_productos as
begin
	select p.nombreprod, p.marca, c.nombre_cat, p.precio from producto p join categoria c 
	on p.cod_cat = c.cod_cat
end

create procedure select_producto_categoria (@nombre_cat varchar) as
begin
	select p.nombreprod, p.marca, c.nombre_cat, p.precio from producto p join categoria c 
	on p.cod_cat = c.cod_cat where c.nombre_cat LIKE '%'+@nombre_cat+'%'
end

create procedure select_carrito as
begin
	select c.cod_prod, p.nombreprod, p.precio, c.cantidad from
	producto p join deseos c on c.cod_prod = p.cod_prod
end

create procedure select_categoria as
begin
	select nombre_cat from categoria
end