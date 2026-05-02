window.saveData = (key, data) => {
    localStorage.setItem(key, JSON.stringify(data));
};

window.getData = (key) => {
    const data = localStorage.getItem(key);
    return data ? JSON.parse(data) : null;
}