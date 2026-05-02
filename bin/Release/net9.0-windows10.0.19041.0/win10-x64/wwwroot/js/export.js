window.downloadFile = function(fileName, base64Content, mimeType) {
    try {
        const dataUrl = 'data:' + mimeType + ';base64,' + base64Content;
        const link = document.createElement('a');
        link.href = dataUrl;
        link.download = fileName;
        link.style.display = 'none';
        document.body.appendChild(link);
        link.click();
        setTimeout(() => {
            document.body.removeChild(link);
        }, 100);
    } catch (error) {
        console.error('Download failed:', error);
    }
};

window.triggerPrint = function() {
    try {
        window.print();
    } catch (error) {
        console.error('Print failed:', error);
    }
};
