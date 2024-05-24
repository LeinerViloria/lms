namespace LMS.Shared.DTOS
{
    public record MenuItemDTO
    {
        public string Title { get; set; } = null!;
        public string Icon { get; set; } = null!;
        public string? Url { get; set; }

        public ICollection<MenuItemDTO> SubMenus { get; set; } = null!;
    }
}
