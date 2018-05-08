-- phpMyAdmin SQL Dump
-- version 4.8.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 08, 2018 at 03:38 PM
-- Server version: 10.1.31-MariaDB
-- PHP Version: 7.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pos_database`
--

-- --------------------------------------------------------

--
-- Table structure for table `gpu_items`
--

CREATE TABLE `gpu_items` (
  `item_name` varchar(255) NOT NULL,
  `qty` varchar(255) NOT NULL,
  `price` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `motherboard_items`
--

CREATE TABLE `motherboard_items` (
  `item_name` varchar(255) NOT NULL,
  `qty` varchar(255) NOT NULL,
  `price` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `processor_items`
--

CREATE TABLE `processor_items` (
  `item_name` varchar(255) NOT NULL,
  `qty` varchar(255) NOT NULL,
  `price` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `processor_items`
--

INSERT INTO `processor_items` (`item_name`, `qty`, `price`, `status`) VALUES
('AMD A6-6400K', '25', '2500', 'On-Stock'),
('AMD A8-7650k(Quad-Core)', '30', '4000', 'On-Stock'),
('AMD A8-9600 Processor', '20', '3700', 'On-Stock'),
('Intel Core 4460', '10', '8600', 'On-Stock'),
('Intel Core i3-7100', '20', '6500', 'On-Stock'),
('Intel Core i5-8400', '20', '10299', 'On-Stock'),
('Intel Core i7-8700', '10', '16000', 'On-Stock'),
('Intel Core i7-8700k', '10', '21000', 'On-Stock'),
('Intel i7-7700K', '10', '18000', 'On-Stock'),
('Intel Pentium G4400', '30', '3000', 'On-Stock'),
('Intel Pentium G4560', '20', '3120', 'On-Stock'),
('Ryzen 1300', '10', '6200', 'On-Stock'),
('Ryzen 1300X', '5', '8500', 'On-Stock'),
('Ryzen 3 2200G Vega Graphics', '5', '6000', 'On-Stock'),
('Ryzen 5 2400G Vega Graphics', '10', '14000', 'On-Stock'),
('Ryzen 5 2600', '13', '11999', 'On-Stock');

-- --------------------------------------------------------

--
-- Table structure for table `ram_items`
--

CREATE TABLE `ram_items` (
  `item_name` varchar(255) NOT NULL,
  `qty` varchar(255) NOT NULL,
  `price` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `motherboard_items`
--
ALTER TABLE `motherboard_items`
  ADD PRIMARY KEY (`item_name`);

--
-- Indexes for table `processor_items`
--
ALTER TABLE `processor_items`
  ADD PRIMARY KEY (`item_name`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
