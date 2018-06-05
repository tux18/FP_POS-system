-- phpMyAdmin SQL Dump
-- version 4.8.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 05, 2018 at 02:35 PM
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
-- Table structure for table `accounts`
--

CREATE TABLE `accounts` (
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `fname` varchar(255) NOT NULL,
  `lname` varchar(255) NOT NULL,
  `status` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`username`, `password`, `fname`, `lname`, `status`) VALUES
('google', 'google', 'googleman', 'wanpage', 'unblock'),
('Mike', 'asdasd', 'asdasd', 'fdgfdg', 'unblock'),
('qweqwe', 'asdqwe', 'dfgfdg', 'fdgdg', 'unblock'),
('test', 'test', 'Justin', 'Tuqs', 'block'),
('test123', 'qwe', 'Junior', 'Barrow', 'unblock'),
('tom123', '11111', 'James', 'Tom', 'unblock');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `cust_id` varchar(100) NOT NULL,
  `full_name` varchar(255) NOT NULL,
  `gender` varchar(255) NOT NULL,
  `contact_num` varchar(25) NOT NULL,
  `address` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Table for Customer';

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`cust_id`, `full_name`, `gender`, `contact_num`, `address`, `status`) VALUES
('001', 'Robert Downy', 'Male', '09356669922', 'Alpha Centaurus', 'ACTIVE'),
('03342', 'Jonathan Millers', 'Male', '00100101010', 'Capella Centaurus', ''),
('1111', 'Helloq', 'Male', '9098765', 'Bonzayzzz', ''),
('23344', 'Jobert Norma', 'MALE', '0022222333', 'Aurora Regalus', '');

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

--
-- Dumping data for table `gpu_items`
--

INSERT INTO `gpu_items` (`item_name`, `qty`, `price`, `status`) VALUES
('AMD Radeon RX560 4GB OC', '5', '9000', 'On-Stock'),
('Geforce 210 1GB DDR3 64 Bit', '2', '1600', 'On-Stock'),
('GeForce GT 730 2GB DDR3', '5', '3400', 'On-Stock'),
('GeForce GTX1050 TI 4GB 128Bit', '15', '9700', 'On-Stock'),
('Palit GTX1060 6GB', '5', '18000', 'On-Stock'),
('Zotac GTX1050 Ti OC 4GB 128Bit', '10', '10000', 'On-Stock');

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

--
-- Dumping data for table `motherboard_items`
--

INSERT INTO `motherboard_items` (`item_name`, `qty`, `price`, `status`) VALUES
('Biostar HI-FI A70U3P FM2+', '40', '2300', 'On-Stock'),
('GB B360 AORUS GAMING 3', '5', '7299', 'On-Stock'),
('Gigabyte GA-H110M-DS2 7th Gen', '10', '3100', 'On-Stock');

-- --------------------------------------------------------

--
-- Table structure for table `peripheral_items`
--

CREATE TABLE `peripheral_items` (
  `item_name` varchar(200) NOT NULL,
  `qty` varchar(50) NOT NULL,
  `price` varchar(100) NOT NULL,
  `status` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `peripheral_items`
--

INSERT INTO `peripheral_items` (`item_name`, `qty`, `price`, `status`) VALUES
('A4Tech Mouse', '30', '160', 'On-Stock');

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
('AMD A6-5400', '17', '3000', 'On-Stock'),
('AMD A6-6400K', '18', '2500', 'On-Stock'),
('AMD A8-7650k(Quad-Core)', '8', '4000', 'On-Stock'),
('AMD A8-9600 Processor', '21', '3700', 'On-Stock'),
('Intel Core 4460', '10', '8600', 'On-Stock'),
('Intel Core i3-7100', '20', '6500', 'On-Stock'),
('Intel Core i5-8400', '20', '10299', 'On-Stock'),
('Intel Core i7-8700', '10', '16000', 'On-Stock'),
('Intel Core i7-8700k', '5', '21000', 'On-Stock'),
('Intel i7-7700K', '10', '18000', 'On-Stock'),
('Intel Pentium G4400', '30', '3000', 'On-Stock'),
('Intel Pentium G4560', '20', '3120', 'On-Stock'),
('Ryzen 1300', '5', '6200', 'On-Stock'),
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
-- Dumping data for table `ram_items`
--

INSERT INTO `ram_items` (`item_name`, `qty`, `price`, `status`) VALUES
('Avexir 4GB 2400MHz DDR4', '14', '2800', 'On-Stock'),
('Corsair V 16GB 2400MHz DDR4', '20', '11000', 'On-Stock'),
('Gskill Aegis 4GB 2400MHz DDR4', '15', '2800', 'On-Stock'),
('Gskill Trident 16GB 3000MHz DDR4', '15', '14500', 'On-Stock'),
('HyperX Fury 8GB 1600MHz DDR3', '20', '3200', 'On-Stock'),
('HyperX Fury 8GB 2400MHz DDR4', '20', '5700', 'On-Stock');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accounts`
--
ALTER TABLE `accounts`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`cust_id`);

--
-- Indexes for table `gpu_items`
--
ALTER TABLE `gpu_items`
  ADD PRIMARY KEY (`item_name`);

--
-- Indexes for table `motherboard_items`
--
ALTER TABLE `motherboard_items`
  ADD PRIMARY KEY (`item_name`);

--
-- Indexes for table `peripheral_items`
--
ALTER TABLE `peripheral_items`
  ADD PRIMARY KEY (`item_name`);

--
-- Indexes for table `processor_items`
--
ALTER TABLE `processor_items`
  ADD PRIMARY KEY (`item_name`);

--
-- Indexes for table `ram_items`
--
ALTER TABLE `ram_items`
  ADD PRIMARY KEY (`item_name`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
