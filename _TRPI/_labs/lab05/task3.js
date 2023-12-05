for (var prop in window) {
    if (window.hasOwnProperty(prop)) {
      let value = window[prop];
      console.log(prop + ":", value);
    }
}