-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';


-- -----------------------------------------------------
-- Table `tipoactividad`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `tipoactividad` (
  `idtipoactividad` INT NOT NULL AUTO_INCREMENT,
  `descripcion` VARCHAR(75) NOT NULL,
  `sincrono` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idtipoactividad`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `actividad`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `actividad` (
  `idactividad` INT NOT NULL AUTO_INCREMENT,
  `fidtipoactividad` INT NOT NULL,
  `nombre` VARCHAR(45) NULL DEFAULT NULL,
  `fechaInicial` DATE NOT NULL,
  `horaincio` TIME NOT NULL,
  `horafin` TIME NOT NULL,
  `activo` TINYINT(1) NULL DEFAULT '1',
  PRIMARY KEY (`idactividad`),
  INDEX `fidtipoactividad_idx` (`fidtipoactividad` ASC) ,
  CONSTRAINT `fk_fidtipoactividad_act`
    FOREIGN KEY (`fidtipoactividad`)
    REFERENCES `tipoactividad` (`idtipoactividad`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `material`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `material` (
  `idmaterial` INT NOT NULL AUTO_INCREMENT,
  `tipoarchivo` VARCHAR(8) NULL DEFAULT NULL,
  `link` VARCHAR(200) NULL DEFAULT NULL,
  `descripcion` VARCHAR(75) NULL DEFAULT NULL,
  `activo` TINYINT(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`idmaterial`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `actividad_material`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `actividad_material` (
  `idactividad_material` INT NOT NULL AUTO_INCREMENT,
  `fidactividad` INT NOT NULL,
  `fidmaterial` INT NOT NULL,
  PRIMARY KEY (`idactividad_material`),
  INDEX `fidactividad_idx` (`fidactividad` ASC) ,
  INDEX `fidmaterial_idx` (`fidmaterial` ASC) ,
  CONSTRAINT `fk_fidactividad_am`
    FOREIGN KEY (`fidactividad`)
    REFERENCES `actividad` (`idactividad`),
  CONSTRAINT `fk_fidmaterial_am`
    FOREIGN KEY (`fidmaterial`)
    REFERENCES `material` (`idmaterial`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `tipoasistencia`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `tipoasistencia` (
  `idtipoasistencia` INT NOT NULL AUTO_INCREMENT,
  `descripcion` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idtipoasistencia`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `usuario` (
  `idusuario` INT NOT NULL AUTO_INCREMENT,
  `user` VARCHAR(75) NOT NULL,
  `password` VARCHAR(25) NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  `tipo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idusuario`),
  UNIQUE INDEX `user_UNIQUE` (`user` ASC) )
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `asistencia`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `asistencia` (
  `idasistencia` INT NOT NULL AUTO_INCREMENT,
  `fidusuario` INT NOT NULL,
  `fidactividad` INT NOT NULL,
  `fidtipoasistencia` INT NOT NULL,
  `descripcion` VARCHAR(250) NULL DEFAULT NULL,
  PRIMARY KEY (`idasistencia`),
  INDEX `fidactividad_idx` (`fidactividad` ASC) ,
  INDEX `fidtipoasistencia_idx` (`fidtipoasistencia` ASC) ,
  INDEX `fidusuario_idx` (`fidusuario` ASC) ,
  CONSTRAINT `fk_fidactividad_asist`
    FOREIGN KEY (`fidactividad`)
    REFERENCES `actividad` (`idactividad`),
  CONSTRAINT `fk_fidtipoasistencia_asist`
    FOREIGN KEY (`fidtipoasistencia`)
    REFERENCES `tipoasistencia` (`idtipoasistencia`),
  CONSTRAINT `fk_fidusuario_asist`
    FOREIGN KEY (`fidusuario`)
    REFERENCES `usuario` (`idusuario`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `persona`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `persona` (
  `idpersona` INT NOT NULL AUTO_INCREMENT,
  `dni` VARCHAR(8) NOT NULL,
  `nombre` VARCHAR(75) NULL DEFAULT NULL,
  `apellidopaterno` VARCHAR(25) NULL DEFAULT NULL,
  `apellidomaterno` VARCHAR(25) NULL DEFAULT NULL,
  `fechanacimiento` DATE NULL DEFAULT NULL,
  `genero` CHAR(1) NULL DEFAULT NULL,
  `edad` TINYINT NULL DEFAULT NULL,
  `telefono` VARCHAR(9) NULL DEFAULT NULL,
  `celular` VARCHAR(9) NULL DEFAULT NULL,
  `correo` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY (`idpersona`),
  UNIQUE INDEX `dni_UNIQUE` (`dni` ASC) )
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `cuidador`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `cuidador` (
  `fidpersona` INT NOT NULL,
  `fidusuario` INT NULL DEFAULT NULL,
  `gestante` TINYINT(1) NULL DEFAULT NULL,
  `bajosrecursos` TINYINT(1) NULL DEFAULT NULL,
  `activo` TINYINT(1) NULL DEFAULT '1',
  PRIMARY KEY (`fidpersona`),
  INDEX `fidusuario_idx` (`fidusuario` ASC) ,
  CONSTRAINT `fk_fidpersona_cuid`
    FOREIGN KEY (`fidpersona`)
    REFERENCES `persona` (`idpersona`),
  CONSTRAINT `fk_fidusuario_cuid`
    FOREIGN KEY (`fidusuario`)
    REFERENCES `usuario` (`idusuario`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `dia`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dia` (
  `iddia` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(25) NOT NULL,
  PRIMARY KEY (`iddia`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `cuidador_dia`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `cuidador_dia` (
  `idcuidador_dia` INT NOT NULL AUTO_INCREMENT,
  `fidcuidador` INT NOT NULL,
  `fiddia` INT NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idcuidador_dia`),
  INDEX `fiddia_idx` (`fiddia` ASC) ,
  INDEX `fidcuidador_idx` (`fidcuidador` ASC) ,
  CONSTRAINT `fk_fidcuidador_cd`
    FOREIGN KEY (`fidcuidador`)
    REFERENCES `cuidador` (`fidpersona`),
  CONSTRAINT `fk_fiddia_cd`
    FOREIGN KEY (`fiddia`)
    REFERENCES `dia` (`iddia`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `dispositivoelectronico`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dispositivoelectronico` (
  `iddispositivoelectronico` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`iddispositivoelectronico`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `cuidador_dispositivoelectronico`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `cuidador_dispositivoelectronico` (
  `idcuidador_dispositivoelectronico` INT NOT NULL AUTO_INCREMENT,
  `fidcuidador` INT NOT NULL,
  `fiddispositivoelectronico` INT NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idcuidador_dispositivoelectronico`),
  INDEX `fiddispositivoelectronico_idx` (`fiddispositivoelectronico` ASC) ,
  INDEX `fidcuidador_idx` (`fidcuidador` ASC) ,
  CONSTRAINT `fk_fidcuidador_cdisp`
    FOREIGN KEY (`fidcuidador`)
    REFERENCES `cuidador` (`fidpersona`),
  CONSTRAINT `fk_fiddispositivoelectronico_cdisp`
    FOREIGN KEY (`fiddispositivoelectronico`)
    REFERENCES `dispositivoelectronico` (`iddispositivoelectronico`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `periodo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `periodo` (
  `idperiodo` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(25) NOT NULL,
  PRIMARY KEY (`idperiodo`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `cuidador_periodo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `cuidador_periodo` (
  `idcuidador_periodo` INT NOT NULL AUTO_INCREMENT,
  `fidcuidador` INT NOT NULL,
  `fidperiodo` INT NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idcuidador_periodo`),
  INDEX `fidcuidador_idx` (`fidcuidador` ASC) ,
  INDEX `fidperiodo_idx` (`fidperiodo` ASC) ,
  CONSTRAINT `fk_fidcuidador_cp`
    FOREIGN KEY (`fidcuidador`)
    REFERENCES `cuidador` (`fidpersona`),
  CONSTRAINT `fk_fidperiodo_cp`
    FOREIGN KEY (`fidperiodo`)
    REFERENCES `periodo` (`idperiodo`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `redsocial`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `redsocial` (
  `idredsocial` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(25) NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idredsocial`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `cuidador_redsocial`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `cuidador_redsocial` (
  `idcuidador_redsocial` INT NOT NULL AUTO_INCREMENT,
  `fidcuidador` INT NOT NULL,
  `fidredsocial` INT NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idcuidador_redsocial`),
  INDEX `fidcuidador_idx` (`fidcuidador` ASC) ,
  INDEX `fidredsocial_idx` (`fidredsocial` ASC) ,
  CONSTRAINT `fk_fidcuidador_cr`
    FOREIGN KEY (`fidcuidador`)
    REFERENCES `cuidador` (`fidpersona`),
  CONSTRAINT `fk_fidredsocial_cr`
    FOREIGN KEY (`fidredsocial`)
    REFERENCES `redsocial` (`idredsocial`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `tipointernet`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `tipointernet` (
  `idtipointernet` INT NOT NULL AUTO_INCREMENT,
  `descripcion` VARCHAR(45) NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idtipointernet`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `cuidador_tipointernet`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `cuidador_tipointernet` (
  `idcuidador_tipointernet` INT NOT NULL AUTO_INCREMENT,
  `fidcuidador` INT NOT NULL,
  `fidtipointernet` INT NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idcuidador_tipointernet`),
  INDEX `fidcuidador_idx` (`fidcuidador` ASC) ,
  INDEX `fidtipointernet_idx` (`fidtipointernet` ASC) ,
  CONSTRAINT `fk_fidcuidador_ct`
    FOREIGN KEY (`fidcuidador`)
    REFERENCES `cuidador` (`fidpersona`),
  CONSTRAINT `fk_fidtipointernet_ct`
    FOREIGN KEY (`fidtipointernet`)
    REFERENCES `tipointernet` (`idtipointernet`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `distrito`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `distrito` (
  `iddistrito` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`iddistrito`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `eje`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `eje` (
  `ideje` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `activo` TINYINT(1) NULL DEFAULT '1',
  PRIMARY KEY (`ideje`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `modulo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `modulo` (
  `idmodulo` INT NOT NULL AUTO_INCREMENT,
  `fechainicial` DATE NOT NULL,
  `fechafinal` DATE NOT NULL,
  `activo` TINYINT(1) NULL DEFAULT '1',
  PRIMARY KEY (`idmodulo`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `grupo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `grupo` (
  `idgrupo` INT NOT NULL AUTO_INCREMENT,
  `fidmodulo` INT NOT NULL,
  `nombre` VARCHAR(25) NULL DEFAULT NULL,
  `activo` TINYINT(1) NULL DEFAULT '1',
  PRIMARY KEY (`idgrupo`),
  INDEX `fidmodulo_idx` (`fidmodulo` ASC) ,
  CONSTRAINT `fk_fidmodulo_grupo`
    FOREIGN KEY (`fidmodulo`)
    REFERENCES `modulo` (`idmodulo`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `seguro`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `seguro` (
  `idseguro` INT NOT NULL AUTO_INCREMENT,
  `proveedor` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idseguro`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `niño`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `niño` (
  `fidpersona` INT NOT NULL,
  `fidseguro` INT NULL DEFAULT NULL,
  `activo` TINYINT(1) NULL DEFAULT NULL,
  PRIMARY KEY (`fidpersona`),
  INDEX `fidseguro_idx` (`fidseguro` ASC) ,
  CONSTRAINT `fk_fidpersona_ni`
    FOREIGN KEY (`fidpersona`)
    REFERENCES `persona` (`idpersona`),
  CONSTRAINT `fk_fidseguro_ni`
    FOREIGN KEY (`fidseguro`)
    REFERENCES `seguro` (`idseguro`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `niño_cuidador`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `niño_cuidador` (
  `idniño_cuidador` INT NOT NULL AUTO_INCREMENT,
  `fidniño` INT NOT NULL,
  `fidcuidador` INT NOT NULL,
  `activo` TINYINT(1) NULL DEFAULT '1',
  PRIMARY KEY (`idniño_cuidador`),
  INDEX `fidniño_idx` (`fidniño` ASC) ,
  INDEX `fidcuidador_idx` (`fidcuidador` ASC) ,
  CONSTRAINT `fk_fidcuidador_nc`
    FOREIGN KEY (`fidcuidador`)
    REFERENCES `cuidador` (`fidpersona`),
  CONSTRAINT `fk_fidniño_nc`
    FOREIGN KEY (`fidniño`)
    REFERENCES `niño` (`fidpersona`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `grupo_niño_cuidador`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `grupo_niño_cuidador` (
  `idgrupo_niño_cuidador` INT NOT NULL AUTO_INCREMENT,
  `fidgrupo` INT NOT NULL,
  `fidniño_cuidador` INT NOT NULL,
  PRIMARY KEY (`idgrupo_niño_cuidador`),
  INDEX `fidniño_cuidador_idx` (`fidniño_cuidador` ASC) ,
  INDEX `fk_fidgrupo_gnc` (`fidgrupo` ASC) ,
  CONSTRAINT `fk_fidgrupo_gnc`
    FOREIGN KEY (`fidgrupo`)
    REFERENCES `grupo` (`idgrupo`),
  CONSTRAINT `fk_fidniño_cuidador_gnc`
    FOREIGN KEY (`fidniño_cuidador`)
    REFERENCES `niño_cuidador` (`idniño_cuidador`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `psicologo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `psicologo` (
  `fidpersona` INT NOT NULL,
  `fidusuario` INT NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`fidpersona`),
  INDEX `fidusuario_idx` (`fidusuario` ASC) ,
  CONSTRAINT `fk_fidpersona_psi`
    FOREIGN KEY (`fidpersona`)
    REFERENCES `persona` (`idpersona`),
  CONSTRAINT `fk_fidusuario_psi`
    FOREIGN KEY (`fidusuario`)
    REFERENCES `usuario` (`idusuario`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `grupo_psicologo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `grupo_psicologo` (
  `idgrupo_psicologo` INT NOT NULL,
  `fidpsicologo` INT NOT NULL,
  `fidgrupo` INT NOT NULL,
  `activo` TINYINT(1) NULL DEFAULT NULL,
  PRIMARY KEY (`idgrupo_psicologo`),
  INDEX `fidpsicologo_idx` (`fidpsicologo` ASC) ,
  INDEX `fidgrupo_idx` (`fidgrupo` ASC) ,
  CONSTRAINT `fidgrupo_gp`
    FOREIGN KEY (`fidgrupo`)
    REFERENCES `grupo` (`idgrupo`),
  CONSTRAINT `fidpsicologo_ps`
    FOREIGN KEY (`fidpsicologo`)
    REFERENCES `psicologo` (`fidpersona`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `modulo_actividad`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `modulo_actividad` (
  `idmodulo_actividad` INT NOT NULL AUTO_INCREMENT,
  `fidmodulo` INT NOT NULL,
  `fidactividad` INT NOT NULL,
  PRIMARY KEY (`idmodulo_actividad`),
  INDEX `fidmodulo_idx` (`fidmodulo` ASC) ,
  INDEX `fidactividad_idx` (`fidactividad` ASC) ,
  CONSTRAINT `fk_fidactividad_ma`
    FOREIGN KEY (`fidactividad`)
    REFERENCES `actividad` (`idactividad`),
  CONSTRAINT `fk_fidmodulo_ma`
    FOREIGN KEY (`fidmodulo`)
    REFERENCES `modulo` (`idmodulo`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `modulo_eje`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `modulo_eje` (
  `idmodulo_eje` INT NOT NULL AUTO_INCREMENT,
  `fidmodulo` INT NOT NULL,
  `fideje` INT NOT NULL,
  PRIMARY KEY (`idmodulo_eje`),
  INDEX `fidmodulo_idx` (`fidmodulo` ASC) ,
  INDEX `fideje_idx` (`fideje` ASC) ,
  CONSTRAINT `fk_fideje_meje`
    FOREIGN KEY (`fideje`)
    REFERENCES `eje` (`ideje`),
  CONSTRAINT `fk_fidmodulo_meje`
    FOREIGN KEY (`fidmodulo`)
    REFERENCES `modulo` (`idmodulo`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `persona_distrito`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `persona_distrito` (
  `idpersona_distrito` INT NOT NULL AUTO_INCREMENT,
  `fiddistrito` INT NOT NULL,
  `fidpersona` INT NOT NULL,
  PRIMARY KEY (`idpersona_distrito`),
  INDEX `fidpersona_idx` (`fidpersona` ASC) ,
  INDEX `fiddistrito_idx` (`fiddistrito` ASC) ,
  CONSTRAINT `fk_fiddistrito_pd`
    FOREIGN KEY (`fiddistrito`)
    REFERENCES `distrito` (`iddistrito`),
  CONSTRAINT `fk_fidpersona_pd`
    FOREIGN KEY (`fidpersona`)
    REFERENCES `persona` (`idpersona`))
ENGINE = InnoDB;




-- -----------------------------------------------------
-- Table `requerimiento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `requerimiento` (
  `idrequerimiento` INT NOT NULL,
  `fidmodulo_1` INT NOT NULL,
  `fidmodulo_2` INT NOT NULL,
  PRIMARY KEY (`idrequerimiento`),
  INDEX `fidmodulo_1_idx` (`fidmodulo_1` ASC) ,
  INDEX `fidmodulo_2_idx` (`fidmodulo_2` ASC) ,
  CONSTRAINT `fidmodulo_1_req`
    FOREIGN KEY (`fidmodulo_1`)
    REFERENCES `modulo` (`idmodulo`),
  CONSTRAINT `fidmodulo_2_req`
    FOREIGN KEY (`fidmodulo_2`)
    REFERENCES `modulo` (`idmodulo`))
ENGINE = InnoDB;


