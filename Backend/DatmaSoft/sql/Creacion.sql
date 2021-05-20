-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema lp2
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema lp2
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `lp2` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `lp2` ;

-- -----------------------------------------------------
-- Table `lp2`.`tipoactividad`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`tipoactividad` ;

CREATE TABLE IF NOT EXISTS `lp2`.`tipoactividad` (
  `idtipoactividad` INT NOT NULL AUTO_INCREMENT,
  `descripcion` VARCHAR(75) NOT NULL,
  `sincrono` TINYINT(1) NOT NULL,
  `activo` VARCHAR(45) NULL DEFAULT NULL,
  `tipoactividadcol` INT NOT NULL,
  PRIMARY KEY (`idtipoactividad`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`actividad`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`actividad` ;

CREATE TABLE IF NOT EXISTS `lp2`.`actividad` (
  `idactividad` INT NOT NULL AUTO_INCREMENT,
  `fidtipoactividad` INT NOT NULL,
  `nombre` VARCHAR(45) NULL DEFAULT NULL,
  `fechaInicial` DATE NOT NULL,
  `horaincio` TIME NOT NULL,
  `horafin` TIME NOT NULL,
  `activo` TINYINT(1) NULL DEFAULT '1',
  PRIMARY KEY (`idactividad`),
  INDEX `fidtipoactividad_idx` (`fidtipoactividad` ASC) VISIBLE,
  CONSTRAINT `fk_fidtipoactividad_act`
    FOREIGN KEY (`fidtipoactividad`)
    REFERENCES `lp2`.`tipoactividad` (`idtipoactividad`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`material`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`material` ;

CREATE TABLE IF NOT EXISTS `lp2`.`material` (
  `idmaterial` INT NOT NULL AUTO_INCREMENT,
  `tipoarchivo` VARCHAR(8) NULL DEFAULT NULL,
  `link` VARCHAR(200) NULL DEFAULT NULL,
  `descripcion` VARCHAR(75) NULL DEFAULT NULL,
  `activo` TINYINT(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`idmaterial`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`actividad_material`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`actividad_material` ;

CREATE TABLE IF NOT EXISTS `lp2`.`actividad_material` (
  `idactividad_material` INT NOT NULL AUTO_INCREMENT,
  `fidactividad` INT NOT NULL,
  `fidmaterial` INT NOT NULL,
  `activo` INT NOT NULL,
  PRIMARY KEY (`idactividad_material`),
  INDEX `fidactividad_idx` (`fidactividad` ASC) VISIBLE,
  INDEX `fidmaterial_idx` (`fidmaterial` ASC) VISIBLE,
  CONSTRAINT `fk_fidactividad_am`
    FOREIGN KEY (`fidactividad`)
    REFERENCES `lp2`.`actividad` (`idactividad`),
  CONSTRAINT `fk_fidmaterial_am`
    FOREIGN KEY (`fidmaterial`)
    REFERENCES `lp2`.`material` (`idmaterial`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`tipoasistencia`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`tipoasistencia` ;

CREATE TABLE IF NOT EXISTS `lp2`.`tipoasistencia` (
  `idtipoasistencia` INT NOT NULL AUTO_INCREMENT,
  `descripcion` VARCHAR(45) NOT NULL,
  `activo` INT NOT NULL,
  PRIMARY KEY (`idtipoasistencia`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`usuario`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`usuario` ;

CREATE TABLE IF NOT EXISTS `lp2`.`usuario` (
  `idusuario` INT NOT NULL AUTO_INCREMENT,
  `user` VARCHAR(75) NOT NULL,
  `password` VARCHAR(25) NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  `tipo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idusuario`),
  UNIQUE INDEX `user_UNIQUE` (`user` ASC) VISIBLE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`asistencia`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`asistencia` ;

CREATE TABLE IF NOT EXISTS `lp2`.`asistencia` (
  `idasistencia` INT NOT NULL AUTO_INCREMENT,
  `fidusuario` INT NOT NULL,
  `fidactividad` INT NOT NULL,
  `fidtipoasistencia` INT NOT NULL,
  `descripcion` VARCHAR(250) NULL DEFAULT NULL,
  `activo` INT NOT NULL,
  PRIMARY KEY (`idasistencia`),
  INDEX `fidactividad_idx` (`fidactividad` ASC) VISIBLE,
  INDEX `fidtipoasistencia_idx` (`fidtipoasistencia` ASC) VISIBLE,
  INDEX `fidusuario_idx` (`fidusuario` ASC) VISIBLE,
  CONSTRAINT `fk_fidactividad_asist`
    FOREIGN KEY (`fidactividad`)
    REFERENCES `lp2`.`actividad` (`idactividad`),
  CONSTRAINT `fk_fidtipoasistencia_asist`
    FOREIGN KEY (`fidtipoasistencia`)
    REFERENCES `lp2`.`tipoasistencia` (`idtipoasistencia`),
  CONSTRAINT `fk_fidusuario_asist`
    FOREIGN KEY (`fidusuario`)
    REFERENCES `lp2`.`usuario` (`idusuario`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`persona`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`persona` ;

CREATE TABLE IF NOT EXISTS `lp2`.`persona` (
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
  `activo` INT NOT NULL,
  PRIMARY KEY (`idpersona`),
  UNIQUE INDEX `dni_UNIQUE` (`dni` ASC) VISIBLE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`cuidador`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`cuidador` ;

CREATE TABLE IF NOT EXISTS `lp2`.`cuidador` (
  `fidpersona` INT NOT NULL,
  `fidusuario` INT NULL DEFAULT NULL,
  `gestante` TINYINT(1) NULL DEFAULT NULL,
  `bajosrecursos` TINYINT(1) NULL DEFAULT NULL,
  `activo` TINYINT(1) NULL DEFAULT '1',
  PRIMARY KEY (`fidpersona`),
  INDEX `fidusuario_idx` (`fidusuario` ASC) VISIBLE,
  CONSTRAINT `fk_fidpersona_cuid`
    FOREIGN KEY (`fidpersona`)
    REFERENCES `lp2`.`persona` (`idpersona`),
  CONSTRAINT `fk_fidusuario_cuid`
    FOREIGN KEY (`fidusuario`)
    REFERENCES `lp2`.`usuario` (`idusuario`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`dia`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`dia` ;

CREATE TABLE IF NOT EXISTS `lp2`.`dia` (
  `iddia` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(25) NOT NULL,
  `activo` INT NOT NULL,
  PRIMARY KEY (`iddia`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`cuidador_dia`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`cuidador_dia` ;

CREATE TABLE IF NOT EXISTS `lp2`.`cuidador_dia` (
  `idcuidador_dia` INT NOT NULL AUTO_INCREMENT,
  `fidcuidador` INT NOT NULL,
  `fiddia` INT NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idcuidador_dia`),
  INDEX `fiddia_idx` (`fiddia` ASC) VISIBLE,
  INDEX `fidcuidador_idx` (`fidcuidador` ASC) VISIBLE,
  CONSTRAINT `fk_fidcuidador_cd`
    FOREIGN KEY (`fidcuidador`)
    REFERENCES `lp2`.`cuidador` (`fidpersona`),
  CONSTRAINT `fk_fiddia_cd`
    FOREIGN KEY (`fiddia`)
    REFERENCES `lp2`.`dia` (`iddia`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`dispositivoelectronico`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`dispositivoelectronico` ;

CREATE TABLE IF NOT EXISTS `lp2`.`dispositivoelectronico` (
  `iddispositivoelectronico` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`iddispositivoelectronico`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`cuidador_dispositivoelectronico`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`cuidador_dispositivoelectronico` ;

CREATE TABLE IF NOT EXISTS `lp2`.`cuidador_dispositivoelectronico` (
  `idcuidador_dispositivoelectronico` INT NOT NULL AUTO_INCREMENT,
  `fidcuidador` INT NOT NULL,
  `fiddispositivoelectronico` INT NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idcuidador_dispositivoelectronico`),
  INDEX `fiddispositivoelectronico_idx` (`fiddispositivoelectronico` ASC) VISIBLE,
  INDEX `fidcuidador_idx` (`fidcuidador` ASC) VISIBLE,
  CONSTRAINT `fk_fidcuidador_cdisp`
    FOREIGN KEY (`fidcuidador`)
    REFERENCES `lp2`.`cuidador` (`fidpersona`),
  CONSTRAINT `fk_fiddispositivoelectronico_cdisp`
    FOREIGN KEY (`fiddispositivoelectronico`)
    REFERENCES `lp2`.`dispositivoelectronico` (`iddispositivoelectronico`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`periodo`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`periodo` ;

CREATE TABLE IF NOT EXISTS `lp2`.`periodo` (
  `idperiodo` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(25) NOT NULL,
  `activo` INT NOT NULL,
  PRIMARY KEY (`idperiodo`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`cuidador_periodo`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`cuidador_periodo` ;

CREATE TABLE IF NOT EXISTS `lp2`.`cuidador_periodo` (
  `idcuidador_periodo` INT NOT NULL AUTO_INCREMENT,
  `fidcuidador` INT NOT NULL,
  `fidperiodo` INT NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idcuidador_periodo`),
  INDEX `fidcuidador_idx` (`fidcuidador` ASC) VISIBLE,
  INDEX `fidperiodo_idx` (`fidperiodo` ASC) VISIBLE,
  CONSTRAINT `fk_fidcuidador_cp`
    FOREIGN KEY (`fidcuidador`)
    REFERENCES `lp2`.`cuidador` (`fidpersona`),
  CONSTRAINT `fk_fidperiodo_cp`
    FOREIGN KEY (`fidperiodo`)
    REFERENCES `lp2`.`periodo` (`idperiodo`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`redsocial`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`redsocial` ;

CREATE TABLE IF NOT EXISTS `lp2`.`redsocial` (
  `idredsocial` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(25) NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idredsocial`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`cuidador_redsocial`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`cuidador_redsocial` ;

CREATE TABLE IF NOT EXISTS `lp2`.`cuidador_redsocial` (
  `idcuidador_redsocial` INT NOT NULL AUTO_INCREMENT,
  `fidcuidador` INT NOT NULL,
  `fidredsocial` INT NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idcuidador_redsocial`),
  INDEX `fidcuidador_idx` (`fidcuidador` ASC) VISIBLE,
  INDEX `fidredsocial_idx` (`fidredsocial` ASC) VISIBLE,
  CONSTRAINT `fk_fidcuidador_cr`
    FOREIGN KEY (`fidcuidador`)
    REFERENCES `lp2`.`cuidador` (`fidpersona`),
  CONSTRAINT `fk_fidredsocial_cr`
    FOREIGN KEY (`fidredsocial`)
    REFERENCES `lp2`.`redsocial` (`idredsocial`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`tipointernet`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`tipointernet` ;

CREATE TABLE IF NOT EXISTS `lp2`.`tipointernet` (
  `idtipointernet` INT NOT NULL AUTO_INCREMENT,
  `descripcion` VARCHAR(45) NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idtipointernet`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`cuidador_tipointernet`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`cuidador_tipointernet` ;

CREATE TABLE IF NOT EXISTS `lp2`.`cuidador_tipointernet` (
  `idcuidador_tipointernet` INT NOT NULL AUTO_INCREMENT,
  `fidcuidador` INT NOT NULL,
  `fidtipointernet` INT NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idcuidador_tipointernet`),
  INDEX `fidcuidador_idx` (`fidcuidador` ASC) VISIBLE,
  INDEX `fidtipointernet_idx` (`fidtipointernet` ASC) VISIBLE,
  CONSTRAINT `fk_fidcuidador_ct`
    FOREIGN KEY (`fidcuidador`)
    REFERENCES `lp2`.`cuidador` (`fidpersona`),
  CONSTRAINT `fk_fidtipointernet_ct`
    FOREIGN KEY (`fidtipointernet`)
    REFERENCES `lp2`.`tipointernet` (`idtipointernet`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`distrito`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`distrito` ;

CREATE TABLE IF NOT EXISTS `lp2`.`distrito` (
  `iddistrito` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `activo` INT NOT NULL,
  PRIMARY KEY (`iddistrito`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`eje`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`eje` ;

CREATE TABLE IF NOT EXISTS `lp2`.`eje` (
  `ideje` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `activo` TINYINT(1) NULL DEFAULT '1',
  PRIMARY KEY (`ideje`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`modulo`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`modulo` ;

CREATE TABLE IF NOT EXISTS `lp2`.`modulo` (
  `idmodulo` INT NOT NULL AUTO_INCREMENT,
  `fechainicial` DATE NOT NULL,
  `fechafinal` DATE NOT NULL,
  `activo` TINYINT(1) NULL DEFAULT '1',
  PRIMARY KEY (`idmodulo`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`grupo`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`grupo` ;

CREATE TABLE IF NOT EXISTS `lp2`.`grupo` (
  `idgrupo` INT NOT NULL AUTO_INCREMENT,
  `fidmodulo` INT NOT NULL,
  `nombre` VARCHAR(25) NULL DEFAULT NULL,
  `activo` TINYINT(1) NULL DEFAULT '1',
  PRIMARY KEY (`idgrupo`),
  INDEX `fidmodulo_idx` (`fidmodulo` ASC) VISIBLE,
  CONSTRAINT `fk_fidmodulo_grupo`
    FOREIGN KEY (`fidmodulo`)
    REFERENCES `lp2`.`modulo` (`idmodulo`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`seguro`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`seguro` ;

CREATE TABLE IF NOT EXISTS `lp2`.`seguro` (
  `idseguro` INT NOT NULL AUTO_INCREMENT,
  `proveedor` VARCHAR(45) NOT NULL,
  `activo` INT NOT NULL,
  PRIMARY KEY (`idseguro`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`niño`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`niño` ;

CREATE TABLE IF NOT EXISTS `lp2`.`niño` (
  `fidpersona` INT NOT NULL,
  `fidseguro` INT NULL DEFAULT NULL,
  `activo` TINYINT(1) NULL DEFAULT NULL,
  PRIMARY KEY (`fidpersona`),
  INDEX `fidseguro_idx` (`fidseguro` ASC) VISIBLE,
  CONSTRAINT `fk_fidpersona_ni`
    FOREIGN KEY (`fidpersona`)
    REFERENCES `lp2`.`persona` (`idpersona`),
  CONSTRAINT `fk_fidseguro_ni`
    FOREIGN KEY (`fidseguro`)
    REFERENCES `lp2`.`seguro` (`idseguro`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`niño_cuidador`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`niño_cuidador` ;

CREATE TABLE IF NOT EXISTS `lp2`.`niño_cuidador` (
  `idniño_cuidador` INT NOT NULL AUTO_INCREMENT,
  `fidniño` INT NOT NULL,
  `fidcuidador` INT NOT NULL,
  `activo` TINYINT(1) NULL DEFAULT '1',
  PRIMARY KEY (`idniño_cuidador`),
  INDEX `fidniño_idx` (`fidniño` ASC) VISIBLE,
  INDEX `fidcuidador_idx` (`fidcuidador` ASC) VISIBLE,
  CONSTRAINT `fk_fidcuidador_nc`
    FOREIGN KEY (`fidcuidador`)
    REFERENCES `lp2`.`cuidador` (`fidpersona`),
  CONSTRAINT `fk_fidniño_nc`
    FOREIGN KEY (`fidniño`)
    REFERENCES `lp2`.`niño` (`fidpersona`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`grupo_niño_cuidador`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`grupo_niño_cuidador` ;

CREATE TABLE IF NOT EXISTS `lp2`.`grupo_niño_cuidador` (
  `idgrupo_niño_cuidador` INT NOT NULL AUTO_INCREMENT,
  `fidgrupo` INT NOT NULL,
  `fidniño_cuidador` INT NOT NULL,
  `activo` INT NOT NULL,
  PRIMARY KEY (`idgrupo_niño_cuidador`),
  INDEX `fidniño_cuidador_idx` (`fidniño_cuidador` ASC) VISIBLE,
  INDEX `fk_fidgrupo_gnc` (`fidgrupo` ASC) VISIBLE,
  CONSTRAINT `fk_fidgrupo_gnc`
    FOREIGN KEY (`fidgrupo`)
    REFERENCES `lp2`.`grupo` (`idgrupo`),
  CONSTRAINT `fk_fidniño_cuidador_gnc`
    FOREIGN KEY (`fidniño_cuidador`)
    REFERENCES `lp2`.`niño_cuidador` (`idniño_cuidador`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`psicologo`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`psicologo` ;

CREATE TABLE IF NOT EXISTS `lp2`.`psicologo` (
  `fidpersona` INT NOT NULL,
  `fidusuario` INT NOT NULL,
  `activo` TINYINT(1) NOT NULL,
  PRIMARY KEY (`fidpersona`),
  INDEX `fidusuario_idx` (`fidusuario` ASC) VISIBLE,
  CONSTRAINT `fk_fidpersona_psi`
    FOREIGN KEY (`fidpersona`)
    REFERENCES `lp2`.`persona` (`idpersona`),
  CONSTRAINT `fk_fidusuario_psi`
    FOREIGN KEY (`fidusuario`)
    REFERENCES `lp2`.`usuario` (`idusuario`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`grupo_psicologo`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`grupo_psicologo` ;

CREATE TABLE IF NOT EXISTS `lp2`.`grupo_psicologo` (
  `idgrupo_psicologo` INT NOT NULL,
  `fidpsicologo` INT NOT NULL,
  `fidgrupo` INT NOT NULL,
  `activo` TINYINT(1) NULL DEFAULT NULL,
  PRIMARY KEY (`idgrupo_psicologo`),
  INDEX `fidpsicologo_idx` (`fidpsicologo` ASC) VISIBLE,
  INDEX `fidgrupo_idx` (`fidgrupo` ASC) VISIBLE,
  CONSTRAINT `fidgrupo`
    FOREIGN KEY (`fidgrupo`)
    REFERENCES `lp2`.`grupo` (`idgrupo`),
  CONSTRAINT `fidpsicologo`
    FOREIGN KEY (`fidpsicologo`)
    REFERENCES `lp2`.`psicologo` (`fidpersona`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`modulo_actividad`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`modulo_actividad` ;

CREATE TABLE IF NOT EXISTS `lp2`.`modulo_actividad` (
  `idmodulo_actividad` INT NOT NULL AUTO_INCREMENT,
  `fidmodulo` INT NOT NULL,
  `fidactividad` INT NOT NULL,
  `activo` INT NOT NULL,
  PRIMARY KEY (`idmodulo_actividad`),
  INDEX `fidmodulo_idx` (`fidmodulo` ASC) VISIBLE,
  INDEX `fidactividad_idx` (`fidactividad` ASC) VISIBLE,
  CONSTRAINT `fk_fidactividad_ma`
    FOREIGN KEY (`fidactividad`)
    REFERENCES `lp2`.`actividad` (`idactividad`),
  CONSTRAINT `fk_fidmodulo_ma`
    FOREIGN KEY (`fidmodulo`)
    REFERENCES `lp2`.`modulo` (`idmodulo`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`modulo_eje`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`modulo_eje` ;

CREATE TABLE IF NOT EXISTS `lp2`.`modulo_eje` (
  `idmodulo_eje` INT NOT NULL AUTO_INCREMENT,
  `fidmodulo` INT NOT NULL,
  `fideje` INT NOT NULL,
  `activo` INT NOT NULL,
  PRIMARY KEY (`idmodulo_eje`),
  INDEX `fidmodulo_idx` (`fidmodulo` ASC) VISIBLE,
  INDEX `fideje_idx` (`fideje` ASC) VISIBLE,
  CONSTRAINT `fk_fideje_meje`
    FOREIGN KEY (`fideje`)
    REFERENCES `lp2`.`eje` (`ideje`),
  CONSTRAINT `fk_fidmodulo_meje`
    FOREIGN KEY (`fidmodulo`)
    REFERENCES `lp2`.`modulo` (`idmodulo`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`persona_distrito`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`persona_distrito` ;

CREATE TABLE IF NOT EXISTS `lp2`.`persona_distrito` (
  `idpersona_distrito` INT NOT NULL AUTO_INCREMENT,
  `fiddistrito` INT NOT NULL,
  `fidpersona` INT NOT NULL,
  `activo` INT NOT NULL,
  PRIMARY KEY (`idpersona_distrito`),
  INDEX `fidpersona_idx` (`fidpersona` ASC) VISIBLE,
  INDEX `fiddistrito_idx` (`fiddistrito` ASC) VISIBLE,
  CONSTRAINT `fk_fiddistrito_pd`
    FOREIGN KEY (`fiddistrito`)
    REFERENCES `lp2`.`distrito` (`iddistrito`),
  CONSTRAINT `fk_fidpersona_pd`
    FOREIGN KEY (`fidpersona`)
    REFERENCES `lp2`.`persona` (`idpersona`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `lp2`.`requerimiento`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `lp2`.`requerimiento` ;

CREATE TABLE IF NOT EXISTS `lp2`.`requerimiento` (
  `idrequerimiento` INT NOT NULL,
  `fidmodulo_1` INT NOT NULL,
  `fidmodulo_2` INT NOT NULL,
  `activo` INT NOT NULL,
  PRIMARY KEY (`idrequerimiento`),
  INDEX `fidmodulo_1_idx` (`fidmodulo_1` ASC) VISIBLE,
  INDEX `fidmodulo_2_idx` (`fidmodulo_2` ASC) VISIBLE,
  CONSTRAINT `fidmodulo_1`
    FOREIGN KEY (`fidmodulo_1`)
    REFERENCES `lp2`.`modulo` (`idmodulo`),
  CONSTRAINT `fidmodulo_2`
    FOREIGN KEY (`fidmodulo_2`)
    REFERENCES `lp2`.`modulo` (`idmodulo`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
