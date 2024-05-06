using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DATA;

public partial class SistemaEducacionContext : DbContext
{
    public SistemaEducacionContext()
    {
    }

    public SistemaEducacionContext(DbContextOptions<SistemaEducacionContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActividadesCulturale> ActividadesCulturales { get; set; }

    public virtual DbSet<ActividadesExtra> ActividadesExtras { get; set; }

    public virtual DbSet<AlmacenamientoArchivo> AlmacenamientoArchivos { get; set; }

    public virtual DbSet<AsistenciaProfesore> AsistenciaProfesores { get; set; }

    public virtual DbSet<Asistencium> Asistencia { get; set; }

    public virtual DbSet<BeneficiosEstudiante> BeneficiosEstudiantes { get; set; }

    public virtual DbSet<Biblioteca> Bibliotecas { get; set; }

    public virtual DbSet<Calificacione> Calificaciones { get; set; }

    public virtual DbSet<CertificadosDiploma> CertificadosDiplomas { get; set; }

    public virtual DbSet<ClubesEstudiante> ClubesEstudiantes { get; set; }

    public virtual DbSet<ComedorEscolar> ComedorEscolars { get; set; }

    public virtual DbSet<Disciplina> Disciplinas { get; set; }

    public virtual DbSet<Estudiante> Estudiantes { get; set; }

    public virtual DbSet<EvaluacionCDocente> EvaluacionCDocentes { get; set; }

    public virtual DbSet<EvaluacionProfesore> EvaluacionProfesores { get; set; }

    public virtual DbSet<Evaluacione> Evaluaciones { get; set; }

    public virtual DbSet<Evento> Eventos { get; set; }

    public virtual DbSet<Grado> Grados { get; set; }

    public virtual DbSet<Horario> Horarios { get; set; }

    public virtual DbSet<IncidentesTEscolar> IncidentesTEscolars { get; set; }

    public virtual DbSet<Inscripcione> Inscripciones { get; set; }

    public virtual DbSet<InventarioLaboratorio> InventarioLaboratorios { get; set; }

    public virtual DbSet<Materia> Materias { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<PrestamosLibro> PrestamosLibros { get; set; }

    public virtual DbSet<Profesore> Profesores { get; set; }

    public virtual DbSet<ProgramaIntercambio> ProgramaIntercambios { get; set; }

    public virtual DbSet<ProgresoAcademico> ProgresoAcademicos { get; set; }

    public virtual DbSet<Recurso> Recursos { get; set; }

    public virtual DbSet<RecursosTecnologico> RecursosTecnologicos { get; set; }

    public virtual DbSet<RegistroAcceso> RegistroAccesos { get; set; }

    public virtual DbSet<RegistroInfraestructura> RegistroInfraestructuras { get; set; }

    public virtual DbSet<Reunione> Reuniones { get; set; }

    public virtual DbSet<Seccione> Secciones { get; set; }

    public virtual DbSet<SeguridadEmergencia> SeguridadEmergencias { get; set; }

    public virtual DbSet<SolicitudPermisoEstudiante> SolicitudPermisoEstudiantes { get; set; }

    public virtual DbSet<Solicitude> Solicitudes { get; set; }

    public virtual DbSet<SolicitudesEmpleo> SolicitudesEmpleos { get; set; }

    public virtual DbSet<SubvencioneBeca> SubvencioneBecas { get; set; }

    public virtual DbSet<TransporteEscolar> TransporteEscolars { get; set; }

    public virtual DbSet<Tutoria> Tutorias { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-TB39PMF\\LOCAL; DataBase=SISTEMA-EDUCACION; TrustServerCertificate=True; Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActividadesCulturale>(entity =>
        {
            entity.ToTable("ACTIVIDADES_CULTURALES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Actividad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACTIVIDAD");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Responsable)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("RESPONSABLE");
        });

        modelBuilder.Entity<ActividadesExtra>(entity =>
        {
            entity.ToTable("ACTIVIDADES_EXTRA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Actividad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACTIVIDAD");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Horario)
                .HasColumnType("datetime")
                .HasColumnName("HORARIO");
            entity.Property(e => e.Responsable)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("RESPONSABLE");
        });

        modelBuilder.Entity<AlmacenamientoArchivo>(entity =>
        {
            entity.ToTable("ALMACENAMIENTO_ARCHIVOS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Archivo)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("ARCHIVO");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Tipo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TIPO");
        });

        modelBuilder.Entity<AsistenciaProfesore>(entity =>
        {
            entity.ToTable("ASISTENCIA_PROFESORES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Asistemcia).HasColumnName("ASISTEMCIA");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("PROFESOR");
        });

        modelBuilder.Entity<Asistencium>(entity =>
        {
            entity.ToTable("ASISTENCIA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Asistencia).HasColumnName("ASISTENCIA");
            entity.Property(e => e.Estudiante)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ESTUDIANTE");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
        });

        modelBuilder.Entity<BeneficiosEstudiante>(entity =>
        {
            entity.ToTable("BENEFICIOS_ESTUDIANTES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Beneficio)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("BENEFICIO");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.FechaFinal)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_FINAL");
            entity.Property(e => e.FechaInicio)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_INICIO");
            entity.Property(e => e.Requisitos)
                .HasColumnType("text")
                .HasColumnName("REQUISITOS");
        });

        modelBuilder.Entity<Biblioteca>(entity =>
        {
            entity.ToTable("BIBLIOTECA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Autor)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("AUTOR");
            entity.Property(e => e.Disponibilidad)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DISPONIBILIDAD");
            entity.Property(e => e.Genero)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("GENERO");
            entity.Property(e => e.Titulo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TITULO");
        });

        modelBuilder.Entity<Calificacione>(entity =>
        {
            entity.ToTable("CALIFICACIONES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Calificacion).HasColumnName("CALIFICACION");
            entity.Property(e => e.Estudiante)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ESTUDIANTE");
            entity.Property(e => e.Grado)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("GRADO");
        });

        modelBuilder.Entity<CertificadosDiploma>(entity =>
        {
            entity.ToTable("CERTIFICADOS_DIPLOMAS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Estudiante)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ESTUDIANTE");
            entity.Property(e => e.FechaEmision)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_EMISION");
            entity.Property(e => e.Tipo)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("TIPO");
        });

        modelBuilder.Entity<ClubesEstudiante>(entity =>
        {
            entity.ToTable("CLUBES_ESTUDIANTES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Club)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CLUB");
            entity.Property(e => e.DiaReunion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DIA_REUNION");
            entity.Property(e => e.Responsable)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("RESPONSABLE");
        });

        modelBuilder.Entity<ComedorEscolar>(entity =>
        {
            entity.ToTable("COMEDOR_ESCOLAR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Estudiante)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ESTUDIANTE");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Menu)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("MENU");
        });

        modelBuilder.Entity<Disciplina>(entity =>
        {
            entity.ToTable("DISCIPLINA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Estudiante)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ESTUDIANTE");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
        });

        modelBuilder.Entity<Estudiante>(entity =>
        {
            entity.ToTable("ESTUDIANTES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Direccion)
                .HasColumnType("text")
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Fechanacimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHANACIMIENTO");
            entity.Property(e => e.Grado)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("GRADO");
            entity.Property(e => e.Nombrecompleto)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("NOMBRECOMPLETO");
            entity.Property(e => e.Sexo)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("SEXO");
        });

        modelBuilder.Entity<EvaluacionCDocente>(entity =>
        {
            entity.ToTable("EVALUACION_C_DOCENTES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompetenciasEvaluadas)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("COMPETENCIAS_EVALUADAS");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Profesor)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("PROFESOR");
            entity.Property(e => e.Puntuacion).HasColumnName("PUNTUACION");
        });

        modelBuilder.Entity<EvaluacionProfesore>(entity =>
        {
            entity.ToTable("EVALUACION_PROFESORES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Calificacion).HasColumnName("CALIFICACION");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.FechaEvaluacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_EVALUACION");
            entity.Property(e => e.Profesor)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("PROFESOR");
        });

        modelBuilder.Entity<Evaluacione>(entity =>
        {
            entity.ToTable("EVALUACIONES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Grado)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("GRADO");
            entity.Property(e => e.TipoEvaluacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TIPO_EVALUACION");
        });

        modelBuilder.Entity<Evento>(entity =>
        {
            entity.ToTable("EVENTOS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Evento1)
                .HasMaxLength(90)
                .IsUnicode(false)
                .HasColumnName("EVENTO");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Lugar)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("LUGAR");
        });

        modelBuilder.Entity<Grado>(entity =>
        {
            entity.ToTable("GRADOS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Horario)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("HORARIO");
            entity.Property(e => e.NombreGrado)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_GRADO");
            entity.Property(e => e.Profesor)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("PROFESOR");
        });

        modelBuilder.Entity<Horario>(entity =>
        {
            entity.ToTable("HORARIOS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DiasSemana)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("DIAS_SEMANA");
            entity.Property(e => e.Grado)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("GRADO");
            entity.Property(e => e.HoraFinal).HasColumnName("HORA_FINAL");
            entity.Property(e => e.HoraInicio).HasColumnName("HORA_INICIO");
        });

        modelBuilder.Entity<IncidentesTEscolar>(entity =>
        {
            entity.ToTable("INCIDENTES_T_ESCOLAR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccionTomada)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACCION_TOMADA");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.RutaAfectada)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RUTA_AFECTADA");
        });

        modelBuilder.Entity<Inscripcione>(entity =>
        {
            entity.ToTable("INSCRIPCIONES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Estudiante)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ESTUDIANTE");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Grado)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("GRADO");
        });

        modelBuilder.Entity<InventarioLaboratorio>(entity =>
        {
            entity.ToTable("INVENTARIO_LABORATORIO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Articulo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Estado)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
        });

        modelBuilder.Entity<Materia>(entity =>
        {
            entity.ToTable("MATERIAS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Creditos).HasColumnName("CREDITOS");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Materia1)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("MATERIA");
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.ToTable("PAGOS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Estudiante)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ESTUDIANTE");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.MetodoPago)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("METODO_PAGO");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("MONTO");
        });

        modelBuilder.Entity<PrestamosLibro>(entity =>
        {
            entity.ToTable("PRESTAMOS_LIBROS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Estudiante)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ESTUDIANTE");
            entity.Property(e => e.FechaDevolucion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DEVOLUCION");
            entity.Property(e => e.FechaPrestamo)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_PRESTAMO");
            entity.Property(e => e.Libro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LIBRO");
        });

        modelBuilder.Entity<Profesore>(entity =>
        {
            entity.ToTable("PROFESORES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Direccion)
                .HasColumnType("text")
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Fechanacimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHANACIMIENTO");
            entity.Property(e => e.Mail)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("MAIL");
            entity.Property(e => e.Materia)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("MATERIA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Sexo)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("SEXO");
            entity.Property(e => e.Telefono).HasColumnName("TELEFONO");
        });

        modelBuilder.Entity<ProgramaIntercambio>(entity =>
        {
            entity.ToTable("PROGRAMA_INTERCAMBIO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Duracion)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DURACION");
            entity.Property(e => e.PaisDestino)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PAIS_DESTINO");
            entity.Property(e => e.Programa)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("PROGRAMA");
        });

        modelBuilder.Entity<ProgresoAcademico>(entity =>
        {
            entity.ToTable("PROGRESO_ACADEMICO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Estudiante)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ESTUDIANTE");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Observacion)
                .HasColumnType("text")
                .HasColumnName("OBSERVACION");
        });

        modelBuilder.Entity<Recurso>(entity =>
        {
            entity.ToTable("RECURSOS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CantDisponible).HasColumnName("CANT_DISPONIBLE");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Recurso1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RECURSO");
            entity.Property(e => e.Ubicacion)
                .HasColumnType("text")
                .HasColumnName("UBICACION");
        });

        modelBuilder.Entity<RecursosTecnologico>(entity =>
        {
            entity.ToTable("RECURSOS_TECNOLOGICOS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Recurso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RECURSO");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UBICACION");
        });

        modelBuilder.Entity<RegistroAcceso>(entity =>
        {
            entity.ToTable("REGISTRO_ACCESO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Resultado)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RESULTADO");
            entity.Property(e => e.TipoAcceso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TIPO_ACCESO");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        });

        modelBuilder.Entity<RegistroInfraestructura>(entity =>
        {
            entity.ToTable("REGISTRO_INFRAESTRUCTURA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Edificio)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("EDIFICIO");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.FechaUltimoMantenimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ULTIMO_MANTENIMIENTO");
        });

        modelBuilder.Entity<Reunione>(entity =>
        {
            entity.ToTable("REUNIONES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Lugar)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUGAR");
            entity.Property(e => e.Participantes).HasColumnName("PARTICIPANTES");
        });

        modelBuilder.Entity<Seccione>(entity =>
        {
            entity.ToTable("SECCIONES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Estudiante)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ESTUDIANTE");
            entity.Property(e => e.Seccion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SECCION");
        });

        modelBuilder.Entity<SeguridadEmergencia>(entity =>
        {
            entity.ToTable("SEGURIDAD_EMERGENCIAS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccionesTomadas)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ACCIONES_TOMADAS");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO");
        });

        modelBuilder.Entity<SolicitudPermisoEstudiante>(entity =>
        {
            entity.ToTable("SOLICITUD_PERMISO_ESTUDIANTE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Estudiante)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ESTUDIANTE");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Tipo)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("TIPO");
        });

        modelBuilder.Entity<Solicitude>(entity =>
        {
            entity.ToTable("SOLICITUDES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Estado)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.TipoSolicitud)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIPO_SOLICITUD");
        });

        modelBuilder.Entity<SolicitudesEmpleo>(entity =>
        {
            entity.ToTable("SOLICITUDES_EMPLEO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Estado)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.PuestoSolicitado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PUESTO_SOLICITADO");
            entity.Property(e => e.Solicitante)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("SOLICITANTE");
        });

        modelBuilder.Entity<SubvencioneBeca>(entity =>
        {
            entity.ToTable("SUBVENCIONE_BECAS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Beneficiario)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("BENEFICIARIO");
            entity.Property(e => e.FechaOtorgamiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_OTORGAMIENTO");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("MONTO");
            entity.Property(e => e.Tipo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TIPO");
        });

        modelBuilder.Entity<TransporteEscolar>(entity =>
        {
            entity.ToTable("TRANSPORTE_ESCOLAR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Conductor)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("CONDUCTOR");
            entity.Property(e => e.Estudiante)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ESTUDIANTE");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Ruta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RUTA");
        });

        modelBuilder.Entity<Tutoria>(entity =>
        {
            entity.ToTable("TUTORIAS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Estudiante)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ESTUDIANTE");
            entity.Property(e => e.FechaFinal)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_FINAL");
            entity.Property(e => e.FechaInicio)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_INICIO");
            entity.Property(e => e.Profesor)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("PROFESOR");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("USUARIOS");

            entity.Property(e => e.Pass)
                .IsUnicode(false)
                .HasColumnName("PASS");
            entity.Property(e => e.Usuario1)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
