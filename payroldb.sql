-- phpMyAdmin SQL Dump
-- version 4.8.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 20, 2018 at 05:14 AM
-- Server version: 10.1.32-MariaDB
-- PHP Version: 7.2.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `payroldb`
--

-- --------------------------------------------------------

--
-- Table structure for table `autonumber`
--

CREATE TABLE `autonumber` (
  `id` int(11) NOT NULL,
  `autoname` varchar(30) NOT NULL,
  `strnum` int(11) NOT NULL,
  `increment` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `autonumber`
--

INSERT INTO `autonumber` (`id`, `autoname`, `strnum`, `increment`) VALUES
(1, 'trans', 19, 1);

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `emp_code` varchar(30) NOT NULL,
  `emp_fname` varchar(60) DEFAULT NULL,
  `emp_lname` varchar(60) DEFAULT NULL,
  `emp_mname` varchar(60) DEFAULT NULL,
  `address` varchar(100) DEFAULT NULL,
  `contact` int(20) DEFAULT NULL,
  `status` varchar(30) DEFAULT NULL,
  `birth_date` date DEFAULT NULL,
  `birth_place` varchar(100) DEFAULT NULL,
  `emp_sex` varchar(10) DEFAULT NULL,
  `emp_age` int(10) DEFAULT NULL,
  `emerg_contct` int(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`emp_code`, `emp_fname`, `emp_lname`, `emp_mname`, `address`, `contact`, `status`, `birth_date`, `birth_place`, `emp_sex`, `emp_age`, `emerg_contct`) VALUES
('am29', 'Anna', 'Malvas', 'Lopez', 'Villa Socorro, Kabankalan City', 54546735, 'Single', '1989-07-07', 'Kabankalan City', 'FEMALE', 24, 54546735),
('by6', 'Bert', 'Yanson', 'Uy', 'Brgy. 3, Kabankalan City', 457892, 'Married', '1988-08-23', 'Kabankankalan City', 'MALE', 25, 457892),
('cg4', 'Joan', 'Geasin', 'Selvano', 'Brgy. 6, Kabankalan City', 4712134, 'single', '1987-02-13', 'Pontevedra ', 'FEMALE', 26, 4712134),
('jf30', 'Joan', 'Geasin', 'Selvano', 'Brgy. 6, Kabankalan City', 4712134, 'single', '1987-02-13', 'Pontevedra ', 'FEMALE', 26, 4712134),
('jha28', 'Jharen', 'Delmez', 'Lacios', 'Dancalan, Ilog', 958, 'Single', '1990-09-28', 'Dancalan, Ilog', 'FEMALE', 23, 958),
('jl4', 'Jade', 'Linco', 'Lopez', 'Brgy. Talubangi', 2147483647, 'Single', '1988-05-23', 'Kab.City', 'FEMALE', 25, 2147483647),
('jo1', 'Joan', 'Geasin', 'Selvano', 'Brgy. 6, Kabankalan City', 4712134, 'single', '1987-02-13', 'Pontevedra ', 'MALE', 26, 4712134),
('jt17', 'Kobe', 'Bryant', 'James', 'Los Angeles, California', 63211, 'Married', '2014-02-12', 'Chicago', 'MALE', 32, 63211),
('kp2', 'Katy', 'Parey', 'Kim', 'Kabankalan City', 2312312, 'single', '1989-01-12', 'Kabankalan City', 'FEMALE', 24, 2312312),
('zso12', 'Zoei shane', 'Omagap', 'Gomez', 'Brgy.1, Kabankalan City', 4657679, 'Single', '1985-12-09', 'Kabankalan City', 'FEMALE', 28, 4657679);

-- --------------------------------------------------------

--
-- Table structure for table `employee_workinfo`
--

CREATE TABLE `employee_workinfo` (
  `id` int(10) NOT NULL,
  `emp_code` varchar(10) NOT NULL,
  `d_rate` int(30) DEFAULT NULL,
  `p_method` varchar(60) DEFAULT NULL,
  `position` varchar(60) DEFAULT NULL,
  `w_status` varchar(60) DEFAULT NULL,
  `d_hired` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee_workinfo`
--

INSERT INTO `employee_workinfo` (`id`, `emp_code`, `d_rate`, `p_method`, `position`, `w_status`, `d_hired`) VALUES
(1, 'jo1', 230, 'weekly', 'casual', 'active', '2012-12-11'),
(2, 'kp2', 230, 'Weekly', 'Casual', 'Active', '2013-01-23'),
(4, 'jha28', 230, 'weekly', 'casual', 'active', '2013-08-07'),
(5, 'cg4', 230, 'weekly', 'casual', 'active', '2012-12-11'),
(6, 'jl4', 230, 'Weekly', 'Casual', 'Active', '2013-08-21'),
(11, 'zso12', 270, 'weekly', 'regular', 'active', '2000-08-10'),
(13, 'jf30', 230, 'weekly', 'casual', 'active', '2012-12-11'),
(15, 'am29', 300, 'weekly', 'regular', 'active', '2010-07-20'),
(17, 'by6', 270, 'weekly', 'regular', 'active', '2010-08-23'),
(19, 'jt17', 500, 'Weekly', 'casual', 'Active', '2014-02-12'),
(20, 'jha2', 270, 'Weekly', 'casual', 'Active', '2014-03-10'),
(21, 'jha45', 270, 'Weekly', 'casual', 'Active', '2014-03-10');

-- --------------------------------------------------------

--
-- Table structure for table `other_deduction`
--

CREATE TABLE `other_deduction` (
  `KEY` int(11) NOT NULL,
  `trans_id` varchar(30) NOT NULL,
  `emp_code` varchar(10) DEFAULT NULL,
  `deduct1` varchar(60) DEFAULT NULL,
  `ded_amount1` int(30) DEFAULT NULL,
  `deduct2` varchar(60) DEFAULT NULL,
  `ded_amount2` int(30) DEFAULT NULL,
  `deduct3` varchar(60) DEFAULT NULL,
  `ded_amount3` int(30) DEFAULT NULL,
  `deduct4` varchar(60) DEFAULT NULL,
  `ded_amount4` int(30) DEFAULT NULL,
  `total_ded` int(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `other_deduction`
--

INSERT INTO `other_deduction` (`KEY`, `trans_id`, `emp_code`, `deduct1`, `ded_amount1`, `deduct2`, `ded_amount2`, `deduct3`, `ded_amount3`, `deduct4`, `ded_amount4`, `total_ded`) VALUES
(1, 'trans5', 'am29', '', 1, '', 1, '', 0, '', 0, 6),
(2, 'trans7', 'am29', '', 1, '', 1, '', 0, '', 0, 6),
(3, 'trans8', 'by6', 'oil', 50, 'uniform', 150, '', 0, '', 0, 550),
(4, 'trans9', '', '', 0, '', 0, '', 0, '', 0, 0),
(5, 'trans10', 'cg4', '', 0, '', 0, '', 0, '', 0, 0),
(6, 'trans11', 'jf30', '', 0, '', 0, '', 0, '', 0, 0),
(7, 'trans12', 'jf30', '', 0, '', 0, '', 0, '', 0, 0),
(8, 'trans13', 'jf30', '', 0, '', 0, '', 0, '', 0, 0),
(9, 'trans14', 'jf30', 'oil', 22, 'uniform', 22, '', 0, '', 0, 145),
(10, 'trans15', 'kp2', 'uniform', 20, '', 0, '', 0, '', 0, 315),
(11, 'trans16', 'by6', 'uniform', 150, '', 0, '', 0, '', 0, 700),
(12, 'trans17', 'by6', 'uniform', 150, '', 0, '', 0, '', 0, 700),
(13, 'trans18', 'am29', '', 0, '', 0, '', 0, '', 0, 700);

-- --------------------------------------------------------

--
-- Table structure for table `payroll`
--

CREATE TABLE `payroll` (
  `KEY` int(11) NOT NULL,
  `emp_code` varchar(10) NOT NULL,
  `num_days` int(30) DEFAULT NULL,
  `r_wage` int(30) DEFAULT NULL,
  `overtime` int(30) DEFAULT NULL,
  `hol_pay` int(30) DEFAULT NULL,
  `gross_sal` int(30) DEFAULT NULL,
  `cash_ad` int(30) DEFAULT NULL,
  `bread_vale` int(30) DEFAULT NULL,
  `philhealth` int(30) DEFAULT NULL,
  `pag-ibig` int(30) DEFAULT NULL,
  `net_income` int(30) DEFAULT NULL,
  `remarks` varchar(100) DEFAULT NULL,
  `dateissued` date NOT NULL,
  `trans_id` varchar(30) NOT NULL DEFAULT '0',
  `user_id` int(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `payroll`
--

INSERT INTO `payroll` (`KEY`, `emp_code`, `num_days`, `r_wage`, `overtime`, `hol_pay`, `gross_sal`, `cash_ad`, `bread_vale`, `philhealth`, `pag-ibig`, `net_income`, `remarks`, `dateissued`, `trans_id`, `user_id`) VALUES
(1, 'am29', 5, 1500, 188, 300, 1988, 1, 1, 1, 1, 1982, '', '2014-03-03', 'trans5', NULL),
(2, 'am29', 5, 1500, 150, 300, 1950, 1, 1, 1, 1, 1944, '', '2014-03-03', 'trans6', NULL),
(3, 'am29', 5, 1500, 150, 300, 1950, 1, 1, 1, 1, 1944, '', '2014-03-03', 'trans7', NULL),
(4, 'by6', 5, 1350, 68, 270, 1688, 200, 50, 50, 50, 1138, '', '2014-03-03', 'trans8', NULL),
(5, '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '', '2014-03-04', 'trans9', NULL),
(6, 'cg4', 5, 1150, 86, 230, 1466, 0, 0, 0, 0, 1466, '', '2014-03-04', 'trans10', NULL),
(7, 'jf30', 5, 1150, 58, 460, 1668, 0, 0, 0, 0, 1668, '', '2014-03-04', 'trans11', NULL),
(8, 'jf30', 4, 920, 144, 1380, 2444, 0, 0, 0, 0, 2444, '', '2014-03-04', 'trans12', NULL),
(9, 'jf30', 5, 1150, 58, 230, 1438, 0, 0, 0, 0, 1438, '', '2014-03-04', 'trans13', NULL),
(10, 'jf30', 4, 920, 115, 230, 1265, 23, 32, 23, 23, 1265, 'sadasdasd', '2014-03-04', 'trans14', NULL),
(11, 'kp2', 5, 1150, 58, 460, 1668, 100, 50, 55, 90, 1353, '', '2014-03-05', 'trans15', NULL),
(12, 'by6', 4, 1080, 135, 810, 2565, 100, 150, 100, 200, 1865, '', '2014-03-10', 'trans16', NULL),
(13, 'by6', 5, 1350, 68, 270, 1688, 150, 100, 100, 200, 988, 'absences', '2014-03-12', 'trans17', NULL),
(14, 'am29', 7, 2100, 113, 1200, 3413, 200, 300, 100, 100, 2713, 'sadsadsadsa', '2014-06-28', 'trans18', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `user_id` int(30) NOT NULL,
  `name` text,
  `username` varchar(60) DEFAULT NULL,
  `pass` varchar(90) DEFAULT NULL,
  `type` varchar(60) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`user_id`, `name`, `username`, `pass`, `type`) VALUES
(12, 'administrator', 'admin', 'd033e22ae348aeb5660fc2140aec35850c4da997', 'Administrator');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `autonumber`
--
ALTER TABLE `autonumber`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`emp_code`),
  ADD UNIQUE KEY `emp_code` (`emp_code`);

--
-- Indexes for table `employee_workinfo`
--
ALTER TABLE `employee_workinfo`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `emp_code_2` (`emp_code`),
  ADD KEY `emp_code` (`emp_code`);

--
-- Indexes for table `other_deduction`
--
ALTER TABLE `other_deduction`
  ADD PRIMARY KEY (`KEY`);

--
-- Indexes for table `payroll`
--
ALTER TABLE `payroll`
  ADD PRIMARY KEY (`KEY`),
  ADD KEY `user_id` (`user_id`),
  ADD KEY `trans_id` (`trans_id`),
  ADD KEY `emp_code` (`emp_code`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `autonumber`
--
ALTER TABLE `autonumber`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `employee_workinfo`
--
ALTER TABLE `employee_workinfo`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT for table `other_deduction`
--
ALTER TABLE `other_deduction`
  MODIFY `KEY` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `payroll`
--
ALTER TABLE `payroll`
  MODIFY `KEY` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `user_id` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
