// wwwroot/js/weathermap.js
let map = null; // Store the map instance globally

window.initWeatherMap = (lat, lon, apiKey) => {
    // If map exists, remove it first
    if (map !== null) {
        map.remove();
    }

    // Create new map instance
    map = L.map('map').setView([lat, lon], 10);

    // Add OpenStreetMap tiles
    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
        attribution: '© <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
    }).addTo(map);

    // Add weather layer
    L.tileLayer(
        `https://tile.openweathermap.org/map/precipitation_new/{z}/{x}/{y}.png?appid=${apiKey}`,
        {
            attribution: 'Weather data © OpenWeatherMap'
        }).addTo(map);

    // Add marker
    L.marker([lat, lon]).addTo(map);
};