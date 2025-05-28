// Last updated: 28/05/2025, 13:14:18
/**
 * @param {integer} init
 * @return { increment: Function, decrement: Function, reset: Function }
 */
var createCounter = function(init) {
    var original = init;

    function increment(){
        return ++init;
    }

    function decrement(){
        return --init;
    }

    function reset(){
        init = original;
        return init;
    }

    return { increment, decrement, reset };
};

/**
 * const counter = createCounter(5)
 * counter.increment(); // 6
 * counter.reset(); // 5
 * counter.decrement(); // 4
 */