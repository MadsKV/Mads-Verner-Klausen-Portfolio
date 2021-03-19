

function topFunction() {
    document.body.scrollTop = 0; 
    document.documentElement.scrollTop = 0; 
}

var app = angular.module('myApp', []);

app.controller('myCtrl', function($scope) {
  
  
  $scope.items = [
 {
      id: 1.1,
      name: '10-19 MPH over',
      jail: 0,
      price: 400,
      lp: 1,
      actions: '',
      class: 'one'
    },
 {
      id: 1.2,
      name: '20-29 MPH over',
      jail: 0,
      price: 1000,
      lp: 2,
      actions: '',
      class: 'one'
    },
 {
      id: 1.3,
      name: '30+ MPH over',
      jail: 0,
      price: 5000,
      lp: 3,
      actions: '',
      class: 'one'
    },
    {
         id: 1.4,
         name: '100+ MPH over',
         jail: 5,
		 maxjail: '10',
         price: 15000,
         actions: 'Impound',
         lp: 4,
         actions: '',
         class: 'one'
       },
       {
            id: 1.5,
            name: '100+ MPH over (Repeated in a month)',
            jail: 5,
			maxjail: '10',
            price: 15000,
            actions: 'Impound',
            lp: 4,
            actions: 'Crush',
            class: 'one'
          },
     {
      id: 1.6,
      name: 'Broken Windshield',
      jail: 0,
      price: 250,
      lp: 0,
      actions: '',
      class: 'one'
    },
 {
      id: 1.7,
      name: 'Driving on a suspended licence (NEW PEOPLE) [WARNING]',
      jail: 0,
      price: 0,
      lp: 0,
      actions: '',
      class: 'one'
    },
 {
      id: 1.8,
      name: 'Driving on a suspended licence (1st)',
      jail: 0,
      price: 10000,
      lp: 0,
	    actions: 'Impound',
      class: 'one'
    },
    {
      id: 1.9,
      name: 'Driving on a suspended licence (2nd)',
      jail: 10,
	  maxjail: '25',
      price: 20000,
      lp: 0,
	    actions: 'Impound',
      class: 'one'
    },
 {
      id: 1.10,
      name: 'Driving on a suspended licence (3rd)',
      jail: 20,
	  maxjail: '45',
      price: 40000,
      lp: 0,
	    actions: 'Crush',
      class: 'one'
    },
 {
      id: 1.11,
      name: 'Excessive vehicle noise',
      jail: 0,
      price: 200,
      lp: 0,
      actions: '',
      class: 'one'
    },
 {
      id: 1.12,
      name: 'Failure of correct use of headlights',
      jail: 0,
      price: 200,
      lp: 0,
      actions: '',
      class: 'one'
    },
 {
      id: 1.13,
      name: 'Failure to stop at red light',
      jail: 0,
      price: 2500,
      lp: 1,
      actions: '',
      class: 'one'
    },
 {
      id: 1.14,
      name: 'Failure to stop at stop sign',
      jail: 0,
      price: 500,
      lp: 1,
      actions: '',
      class: 'one'
    },
 {
      id: 1.15,
      name: 'Failure to yield for emergency vehicles',
      jail: 0,
	  maxjail: '5',
      price: 2000,
      lp: 2,
      actions: '',
      class: 'one'
    },
 {
      id: 1.16,
      name: 'Illegal overtaking',
      jail: 0,
      price: 250,
      lp: 0,
      actions: '',
      class: 'one'
    },
 {
      id: 1.17,
      name: 'Illegal Turn',
      jail: 0,
      price: 1000,
      lp: 0,
      actions: '',
      class: 'one'
    },
 {
      id: 1.18,
      name: 'Illegal Window Tint (Dark)',
      jail: 0,
      price: 1000,
      lp: 0,
      actions: '',
      class: 'one'
    },
{
      id: 1.19,
      name: 'Illegal Window Tint (Dark 2nd offence)',
      jail: 0,
      price: 2000,
      lp: 0,
	    actions: 'Impound',
      class: 'one'
    },
 {
      id: 1.20,
      name: 'Illegally parked vehicle',
      jail: 0,
      price: 1000,
      lp: 0,
      actions: '',
      class: 'one'
    },
 {
      id: 1.21,
      name: 'Illegally parked vehicle blocking spawn',
      jail: 0,
      price: 250,
      lp: 0,
      actions: '',
      class: 'one'
    },
 {
      id: 1.22,
      name: 'Impeding flow of traffic',
      jail: 0,
      price: 500,
      lp: 0,
      actions: '',
      class: 'one'
    },
 {
      id: 1.23,
      name: 'Negligent driving',
      jail: 0,
      price: 2500,
      lp: 2,
      actions: '',
      class: 'one'
    },
 {
      id: 1.24,
      name: 'Reckless driving',
      jail: 0,
	  maxjail: '12',
      price: 12000,
      lp: 4,
	    actions: 'Impound',
      class: 'one'
    },
 {
      id: 1.25,
      name: 'Tailgating',
      jail: 0,
      price: 2000,
      lp: 0,
      actions: '',
      class: 'one'
    },
 {
      id: 1.26,
      name: 'Taillight or headlight out',
      jail: 0,
      price: 2000,
      lp: 0,
      actions: '',
      class: 'one'
    },
 {
      id: 1.27,
      name: 'Travelling wrong way',
      jail: 0,
      price: 1000,
      lp: 4,
      actions: '',
      class: 'one'
    },
     {
      id: 1.28,
      name: 'Use of hydraulic systems on a public highway / risk public safety',
      jail: 0,
      price: 2000,
      lp: 1,
	    actions: 'Impound',
      class: 'one'
    },
   
 {
      id: 1.29,
      name: 'Unroadworthy vehicle',
      jail: 0,
      price: 2000,
      lp: 0,
	    actions: 'Impound',
      class: 'one'
    },
    {
     id: 1.30,
     name: 'Parked on pavement / Red line',
     jail: 0,
     price: 3000,
     lp: 0,
     actions: 'Impound',
     class: 'one'
   },
   {
    id: 1.31,
    name: 'Failure to use seatbelt',
    jail: 0,
    price: 2500,
    lp: 0,
    actions: '',
    class: 'one'
  },
 {
      id: 2.1,
      name: 'Attempted grand theft auto',
      jail: 6,
      price: 1000,
      lp: 0,
      actions: '',
      class: 'two'
    },
     {
      id: 2.2,
      name: 'Brandishing/Improper exhibition of a firearm',
      jail: 22,
      price: 5000,
      lp: 0,
      actions: '',
      class: 'two'
    },
     {
      id: 2.3,
      name: 'Destruction of government property',
      jail: 12,
      price: 10000,
      lp: 0,
      actions: '',
      class: 'two'
    },
     {
      id: 2.4,
      name: 'Disorderly conduct',
      jail: 0,
	  maxjail: '2',
      price: 500,
      lp: 0,
      actions: '',
      class: 'two'
    },
     {
      id: 2.5,
      name: 'Domestic violence',
      jail: 12,
      price: 5000,
      lp: 0,
      actions: '',
      class: 'two'
    },
     {
      id: 2.6,
      name: 'Failure to supply documentation (ID)',
      jail: 9999,
      price: '0',
      lp: 0,
      actions: '',
      class: 'two'
    },
     {
      id: 2.7,
      name: 'False 911 calls',
      jail: 0,
      price: 2000,
      lp: 0,
      actions: '',
      class: 'two'
    },

     {
      id: 2.8,
      name: 'Hit and Run',
      jail: 24,
      price: 2000,
      lp: 0,
      actions: '',
      class: 'two'
    },
     {
      id: 2.9,
      name: 'Jaywalking (Highway)',
      jail: 0,
      price: 1000,
      lp: 0,
      actions: '',
      class: 'two'
    },
     {
      id: 2.10,
      name: 'Possession of burglary tools (per tool)',
      jail: 0,
      price: 1000,
      lp: 0,
      actions: '',
      class: 'two'
    },
       {
      id: 2.11,
      name: 'Public Intoxication (Legion)',
      jail: 0,
	  maxjail: '0',
      price: 750,
      lp: 0,
      actions: '',
      class: 'two'
    },

   {
      id: 2.12,
      name: 'Second degree assault',
      jail: 36,
      price: 2000,
      lp: 0,
      actions: '',
      class: 'two'
    },

   {
      id: 2.13,
      name: 'Stalking',
      jail: 24,
      price: 5000,
      lp: 0,
      actions: '',
      class: 'two'
    },
       {
      id: 2.14,
      name: 'Street racing',
      jail: 12,
      price: 5000,
      lp: 0,
      actions: 'Impound',
      class: 'two'
    },
      {
      id: 2.15,
      name: 'Failure to obey a police direct order',
      jail: 0,
      price: 5000,
      lp: 0,
      actions: '',
      class: 'two'
    },
      {
      id: 2.16,
      name: 'Loitering with intent',
      jail: 10,
      maxjail: '25',
      price: 5000,
      lp: 0,
      actions: '',
      class: 'two'
    },
      {
      id: 2.17,
      name: 'Wasting police time',
      jail: 12,
      maxjail: '24',
      price: 7500,
      lp: 0,
      actions: '',
      class: 'two'
    },
    {
      id: 2.18,
      name: 'Making false statements or perjury',
      jail: 65,
      maxjail: '100',
      price: 40000,
      lp: 0,
      actions: '',
      class: 'two'
    },
    {
      id: 2.19,
      name: 'Unauthorised entry in a federal building',
      jail: 50,
      maxjail: '100',
      price: 15000,
      lp: 0,
      actions: '',
      class: 'two'
    },


     {
      id: 3.1,
      name: 'Aiding and abetting (Copy fine and jail of main suspect)',
      jail: 0,
      price: 0,
      lp: 0,
      actions: '',
      class: 'three'
    },
    {
      id: 3.2,
      name: 'Animal Abuse',
      jail: 12,
      price: 5000,
      lp: 0,
      actions: '',
      class: 'three'
    },
{
      id: 3.3,
      name: 'Armed robbery',
      jail: 80,
	    maxjail: '100',
      price: 40000,
      lp: 0,
      actions: '',
      class: 'three'
    },
    {
      id: 3.4,
      name: 'Assault on LEO or EMS',
      jail: 24,
      maxjail: '36',
      price: 2000,
      lp: 0,
      actions: '',
      class: 'three'
    },
    {
      id: 3.5,
      name: 'Assault of a DA',
      jail: 40,
      maxjail: '80',
      price: 15000,
      lp: 0,
      actions: '',
      class: 'three'
    },
 {
      id: 3.6,
      name: 'Assault with a deadly weapon',
      jail: 36,
	  maxjail: '48',
      price: 4000,
      lp: 0,
      actions: '',
      class: 'three'
    },
{
      id: 3.7,
      name: 'Attempted murder',
      jail: 48,
	  maxjail: '60',
      price: 7500,
      lp: 0,
      actions: '',
      class: 'three'
    },
    {
      id: 3.8,
      name: 'Attempted murder of a LEO or EMS',
      jail: 65,
	    maxjail: '80',
      price: 15000,
      lp: 0,
      actions: '',
      class: 'three'
    },
   {
      id: 3.9,
      name: 'Attempted murder of a DA',
      jail: 9999,
      price: 0,
      lp: 0,
      actions: '',
      class: 'three'
    },
{
      id: 3.10,
      name: 'Bribery of a public servant',
      jail: 2,
	  maxjail: '4',
      price: 2000,
      lp: 0,
      actions: '',
      class: 'three'
    },
{
      id: 3.11,
      name: 'Driving under the influence',
      jail: 24,
	  maxjail: '36',
      price: 3000,
      lp: 0,
      actions: '',
      class: 'three'
    },
 {
      id: 3.12,
      name: 'First degree arson',
      jail: 24,
	  maxjail: '36',
      price: 10000,
      lp: 0,
      actions: '',
      class: 'three'
    },

{
      id: 3.13,
      name: 'Fleeing and eluding',
      jail: 24,
      price: 5000,
      lp: 0,
      actions: '',
      class: 'three'
    },
{
      id: 3.14,
      name: 'Forgery',
      jail: 15,
	  maxjail: '60',
      price: 25000,
      lp: 0,
      actions: '',
      class: 'three'
    },
 {
      id: 3.15,
      name: 'Fraud',
      jail: 15,
	  maxjail: '30',
      price: 25000,
      lp: 0,
      actions: '',
      class: 'three'
    },
    {
      id: 3.16,
      name: 'Grand Theft Auto',
      jail: 24,
      price: 5000,
      lp: 0,
      actions: '',
      class: 'three'
    },
    {
      id: 3.17,
      name: 'Theft of a water vehicle',
      jail: 60,
      maxjail: 80,
      price: 25000,
      lp: 0,
      actions: '',
      class: 'three'
    },
 {
      id: 3.18,
      name: 'Kidnapping',
      jail: 36,
	  maxjail: '48',
      price: 10000,
      lp: 0,
      actions: '',
      class: 'three'
    },
  {
      id: 3.19,
      name: 'Attempt to Hijack Prison Transport',
      jail: 36,
	  maxjail: '48',
      price: 10000,
      lp: 0,
      actions: '',
      class: 'three'
    },
  {
      id: 3.20,
      name: 'Successfull Hijack of Prison Transport',
      jail: 70,
	  maxjail: '80',
      price: 20000,
      lp: 0,
      actions: '',
      class: 'three'
    },
  {
      id: 3.21,
      name: 'Breaking restraining order',
      jail: 60,
	  maxjail: '80',
      price: 8000,
      lp: 0,
      actions: '',
      class: 'three'
    },
    {
      id: 3.22,
      name: 'Commiting crime in area of restraining order',
      jail: 90,
	  maxjail: '110',
      price: 11000,
      lp: 0,
      actions: '',
      class: 'three'
    },
{
      id: 3.23,
      name: 'Manslaughter',
      jail: 60,
	  maxjail: '72',
      price: 4000,
      lp: 0,
      actions: '',
      class: 'three'
    },
 {
      id: 3.24,
      name: 'Murder',
      jail: 9999,
      price: 0,
      lp: 0,
      actions: 'Court',
      class: 'three'
    },
 {
      id: 3.25,
      name: 'Murder of a Local',
      jail: 36,
	  maxjail: '48',
      price: 3000,
      lp: 0,
      actions: '',
      class: 'three'
    },
{
      id: 3.26,
      name: 'Murder of a Police Officer or Emergency Medical Personnel',
      jail: 9999,
      price: 0,
      lp: 0,
      actions: 'Court',
      class: 'three'
    },
 {
      id: 3.27,
      name: 'Obstruction of justice',
      jail: 12,
	  maxjail: '24',
      price: 5000,
      lp: 0,
      actions: '',
      class: 'three'
    },
{
      id: 3.28,
      name: 'Possession of an illegal firearm / Outlawed firearm',
      jail: 24,
      maxjail: '36',
      price: 7000,
      lp: 0,
      actions: '',
      class: 'three'
    },
 {
      id: 3.29,
      name: 'Resisting Arrest',
      jail: 6,
	  maxjail: '12',
      price: 1000,
      lp: 0,
      actions: '',
      class: 'three'
    },
 {
      id: 3.30,
      name: 'Soliciting',
      jail: 36,
      price: 5000,
      lp: 0,
      actions: '',
      class: 'three'
    },
{
      id: 3.31,
      name: 'Terroristic acts',
      jail: 9999,
      price: 0,
      lp: 0,
      actions: 'Court',
      class: 'three'
    },
 {
      id: 3.32,
      name: 'Terroristic threats',
      jail: 36,
	  maxjail: '90',
      price: 6000,
      lp: 0,
      actions: '',
      class: 'three'
    },
{
      id: 3.33,
      name: 'Operating a Stolen Helicopter',
      jail: 50,
	  maxjail: '65',
      price: 25000,
      lp: 0,
      actions: '',
      class: 'three'
    },
{
      id: 3.34,
      name: 'Trespassing',
      jail: 12,
      price: 3000,
      lp: 0,
      actions: '',
      class: 'three'
    },
	{
      id: 3.35,
      name: 'Criminal Threats',
      jail: 10,
	  maxjail: '25',
      price: 10000,
      lp: 0,
      actions: '',
      class: 'three'
    },
    {
      id: 3.36,
      name: 'Harassment',
      jail: 20,
      price: 15000,
      lp: 0,
      actions: '',
      class: 'three'
    },
    {
      id: 3.37,
      name: 'Sexual harassment',
      jail: 30,
      maxjail: '40',
      price: 15000,
      lp: 0,
      actions: '',
      class: 'three'
    },
    {
      id: 3.38,
      name: 'Impersonating a federal officer',
      jail: 20,
      maxjail: '100',
      price: 25000,
      lp: 0,
      actions: '',
      class: 'three'
    },
    {
      id: 3.39,
      name: 'Attempted murder of a federal officer (FIB, Marshall)',
      jail: 80,
      maxjail: '100',
      price: 25000,
      lp: 0,
      actions: '',
      class: 'three'
    },
     {
      id: 4.0,
      name: '4th degree trafficing bags of Weed (1-10)',
      jail: 0,
      price: 5000,
      lp: 0,
      actions: '',
      class: 'four'
    },
     {
      id: 4.1,
      name: '3rd degree trafficing bags of Weed (11-20)',
      jail: 0,
      price: 7500,
      lp: 0,
      actions: '',
      class: 'four'
    },
{
      id: 4.2,
      name: '2nd degree trafficing bags of Weed (21-80)',
      jail: 12,
      price: 10000,
      lp: 0,
      actions: '',
      class: 'four'
    },
 {
      id: 4.3,
      name: '1st degree trafficing bags of Weed (81+)',
      jail: 24,
      price: 12500,
      lp: 0,
      actions: '',
      class: 'four'
    },
{
      id: 4.4,
      name: '3rd degree trafficing Angel-dust / Heroin / Coke (1-20)',
      jail: 12,
      price: 10000,
      lp: 0,
      actions: '',
      class: 'four'
    },
 {
      id: 4.5,
      name: '2nd degree trafficing Angel-dust / Heroin / Coke (20-80)',
      jail: 24,
      price: 15000,
      lp: 0,
      actions: '',
      class: 'four'
    },
{
      id: 4.6,
      name: '1st degree trafficing Angel-dust / Heroin / Coke (81+)',
      jail: 36,
      price: 30000,
      lp: 0,
      actions: 'Watchlist',
      class: 'four'
    },
{
      id: 4.7,
      name: '200+ bags of ANY DRUGS',
      jail: 9999,
      price: 0,
      lp: 0,
      actions: 'Court',
      class: 'four'
    },
{
      id: 4.8,
      name: 'Sharks (1-19)',
      jail: 0,
      price: 2500,
      lp: 0,
      actions: '',
      class: 'four'
    },
 {
      id: 4.9,
      name: 'Sharks (20-39)',
      jail: 0,
      price: 5000,
      lp: 0,
      actions: '',
      class: 'four'
    },
{
      id: 4.10,
      name: 'Sharks (40-79)',
      jail: 0,
	  maxjail: '20',
      price: 10000,
      lp: 0,
      actions: '',
      class: 'four'
    },
  {
      id: 4.11,
      name: 'Sharks (80+)',
      jail: 0,
	  maxjail: '40',
      price: 20000,
      lp: 0,
      actions: '',
      class: 'four'
    },
  {
      id: 4.12,
      name: 'Fishing legal fish without a licence',
      jail: 0,
      price: 2000,
      lp: 0,
      actions: '',
      class: 'four'
    },
  {
      id: 5.1,
      name: 'Suspect vehicle used in drug trafficing (1st Offence)',
      jail: 0,
      price: 0,
      lp: 0,
      actions: 'Impound',
      class: 'five'
    },
  {
      id: 5.2,
      name: 'Suspect vehicle used in drug trafficing (2nd Offence)',
      jail: 0,
      price: 0,
      lp: 0,
      actions: 'Crush',
      class: 'five'
    },
  ];
  
 
  $scope.myItems = [];
  $scope.myActions = [];

  $scope.addItem = function(newItem) {
    if($scope.myItems.length == 0) {
      newItem.count = 1;
      $scope.myItems.push(newItem);

    }else {
      var repeat = false;
      for( var i = 0; i < $scope.myItems.length; i++ ) {
        if($scope.myItems[i].id == newItem.id) {
          $scope.myItems[i].count++;
          repeat = true;
        }
      }
      if(!repeat) {
        newItem.count = 1;
        $scope.myItems.push(newItem);
      }
    }
    updatePrice();
    updateJail();
	    updatemaxJail();
    updateLp();
    updateActions();
  };
  
 
  var updatePrice = function() {
    var totalPrice = 0;
    for( var i = 0; i < $scope.myItems.length; i++ ) {
      totalPrice += ($scope.myItems[i].count) * ($scope.myItems[i].price);
    }
    $scope.totalPrice = totalPrice;
  };

   var updateJail = function() {
    var totalJail = 0;
    for( var i = 0; i < $scope.myItems.length; i++ ) {
      totalJail += ($scope.myItems[i].count) * ($scope.myItems[i].jail);
    }
    $scope.totalJail = totalJail;
  };
  
     var updatemaxJail = function() {
    var totalmaxJail = 0;
    for( var i = 0; i < $scope.myItems.length; i++ ) {
      totalmaxJail += ($scope.myItems[i].count) * ($scope.myItems[i].maxjail);
    }
    $scope.totalmaxJail = totalmaxJail;
  };

  var updateLp = function() {
    var totalLp = 0;
    for( var i = 0; i < $scope.myItems.length; i++ ) {
      totalLp += ($scope.myItems[i].count) * ($scope.myItems[i].lp);
    }
    $scope.totalLp = totalLp;
  };

  var updateActions = function() {
    for( var i = 0; i < $scope.myItems.length; i++ ) {
      if(!$scope.myActions.includes($scope.myItems[i].actions) && $scope.myItems[i].actions != '') {
        $scope.myActions.push($scope.myItems[i].actions);
      }
    }
  };
  

  $scope.removeBasket = function() {
    $scope.myItems.splice(0, $scope.myItems.length);
    $scope.myActions.splice(0, $scope.myActions.length);
    updatePrice();
    updateJail();
	updatemaxJail();
    updateLp();
  };
  
});



app.filter('reverse', function() {
  return function(items) {
    var x = items.slice().reverse();
    if( items.length > 1 ) {
      angular.element('.class').css('background','#fff');
      angular.element('.class').filter(':first').css('background','lightyellow');
      setTimeout(function() {
        angular.element('.class') .filter(':first').css('background','#fff');
      }, 500);
    }
    return x;
  };
});