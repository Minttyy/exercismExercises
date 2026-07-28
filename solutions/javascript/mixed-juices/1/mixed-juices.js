// @ts-check
//
// The line above enables type checking for this file. Various IDEs interpret
// the @ts-check directive. It will give you helpful autocompletion when
// implementing this exercise.

/**
 * Determines how long it takes to prepare a certain juice.
 *
 * @param {string} name
 * @returns {number} time in minutes
 */
export function timeToMixJuice(name) {
  switch (name) {
    case 'Pure Strawberry Joy':
      return 0.5;
    case 'Energizer':
    case 'Green Garden':
      return 1.5;
    case 'Tropical Island':
      return 3;
    case 'All or Nothing':
      return 5;
    default:
      return 2.5;
  }
}

/**
 * Calculates the number of limes that need to be cut
 * to reach a certain supply.
 *
 * @param {number} wedgesNeeded
 * @param {string[]} limes
 * @returns {number} number of limes cut
 */
export function limesToCut(wedgesNeeded, limes) {
  var currentWedges = 0;
  var currentLimes = 0;

  while (currentWedges < wedgesNeeded && currentLimes < limes.length)
    {
      switch(limes[currentLimes]) {
        case "small":
          currentWedges += 6;
          break;
        case 'large':
          currentWedges += 10;
          break;
        case 'medium':
          currentWedges += 8;
          break
        default:
          break;
      }
      currentLimes += 1;
    }

  return currentLimes;
}

/**
 * Determines which juices still need to be prepared after the end of the shift.
 *
 * @param {number} timeLeft
 * @param {string[]} orders
 * @returns {string[]} remaining orders after the time is up
 */
export function remainingOrders(timeLeft, orders) {
  var currentDrink = "";
  
  while (timeLeft > 0){
    timeLeft = timeLeft - timeToMixJuice(orders[0]);
    console.log(timeLeft)
    orders.shift();
  }

  return orders;
}
