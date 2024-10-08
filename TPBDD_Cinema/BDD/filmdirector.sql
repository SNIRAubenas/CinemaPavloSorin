-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Oct 08, 2024 at 09:43 AM
-- Server version: 8.0.30
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `directorfilmactor`
--

-- --------------------------------------------------------

--
-- Table structure for table `filmdirector`
--

CREATE TABLE `filmdirector` (
  `Id` int NOT NULL,
  `idFilm` int NOT NULL,
  `idDirector` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `filmdirector`
--
ALTER TABLE `filmdirector`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `idDirector` (`idDirector`),
  ADD KEY `idFilm` (`idFilm`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `filmdirector`
--
ALTER TABLE `filmdirector`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `filmdirector`
--
ALTER TABLE `filmdirector`
  ADD CONSTRAINT `filmdirector_ibfk_1` FOREIGN KEY (`idDirector`) REFERENCES `director` (`Id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  ADD CONSTRAINT `filmdirector_ibfk_2` FOREIGN KEY (`idFilm`) REFERENCES `film` (`Id`) ON DELETE RESTRICT ON UPDATE RESTRICT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
