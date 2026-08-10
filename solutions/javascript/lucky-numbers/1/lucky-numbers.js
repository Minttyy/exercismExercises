// @ts-check

/**
 * Calculates the sum of the two input arrays.
 *
 * @param {number[]} array1
 * @param {number[]} array2
 * @returns {number} sum of the two arrays
 */
export function twoSum(array1, array2) {
  var num1 = Number(array1.join().replaceAll(",",""))
  var num2 = Number(array2.join().replaceAll(",",""))

  return num1 + num2
}

/**
 * Checks whether a number is a palindrome.
 *
 * @param {number} value
 * @returns {boolean} whether the number is a palindrome or not
 */
export function luckyNumber(value) {
  let rev = String(value).split("").reverse().join("")

  if (rev == String(value))
  {
    return true
  }

  return false
}

/**
 * Determines the error message that should be shown to the user
 * for the given input value.
 *
 * @param {string|null|undefined} input
 * @returns {string} error message
 */
export function errorMessage(input) {
  if (input == '' || input == null)
  {
    return 'Required field'
  }else if (Number(input))
  {
    return ''
  }else {
    return 'Must be a number besides 0'
  }
}
